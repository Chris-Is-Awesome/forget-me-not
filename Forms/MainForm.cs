using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ForgetMeNot
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			ShowCreateReminderPanel();
		}

		// Thanks to Mesmo for this code that restores a window from minimized state
		// (https://stackoverflow.com/a/2725234)
		[DllImport("user32.dll")]
		private static extern int ShowWindow(IntPtr hWnd, uint Msg);
		private const uint SW_RESTORE = 0x09;

		private FrontBackHybrid frontToBack;
		private DateTimePicker remindTime;

		#region MainForm

		private void MainForm_Load(object sender, EventArgs e)
		{
			frontToBack = new FrontBackHybrid(this);
			TopMost = true;

			// Reparent create reminder panel because VS is bad
			createReminder_panel.Parent = right_group;

			DrawRemindersList();
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (FormWindowState.Minimized == WindowState)
				Hide();
		}

		#endregion

		#region Panels

		private void ShowCreateReminderPanel()
		{
			// Toggle panels
			createReminder_panel.Visible = true;
			reminderDetails_panel.Visible = false;
			right_group.Text = "Create reminder";
			createReminderGroup_submitReminder_btn.Text = "Remind me!";

			// Set custom format for date time picker
			remindTime = createReminderGroup_remindTime;
			remindTime.Format = DateTimePickerFormat.Custom;

			// Set start time to be 1 hour ahead of current time
			remindTime.MinDate = DateTime.Now;
			remindTime.Value = remindTime.MinDate.AddHours(1);
		}

		private void ShowReminderDetailsPanel(Reminder.ReminderData reminder)
		{
			if (reminder != null)
			{
				// Toggle panels
				createReminder_panel.Visible = false;
				reminderDetails_panel.Visible = true;
				right_group.Text = "Reminder details";

				// Show reminder details
				reminderDetails_message.Text = reminder.Message;
				reminderDetails_remindTime.Text = $"Reminds at: {reminder.Time.ToLocalTime()}";
				reminderDetails_createdAtTime.Text = $"Created at {reminder.CreatedAt.ToLocalTime()}";
				reminderDetails_isSnoozeable.Text = $"Is snoozeable: {reminder.SnoozingAllowed}";
			}
		}

		#endregion

		#region CreateReminder

		private void remindIn30Minutes_btn_Click(object sender, EventArgs e)
		{
			remindTime.Value = remindTime.Value.AddMinutes(30);
		}

		private void remindIn1Hour_btn_Click(object sender, EventArgs e)
		{
			remindTime.Value = remindTime.Value.AddHours(1);
		}

		private void remindIn6Hours_btn_Click(object sender, EventArgs e)
		{
			remindTime.Value = remindTime.Value.AddHours(6);
		}

		private void remindInMorning_btn_Click(object sender, EventArgs e)
		{
			// TEMP: Hardcode "morning" time. In the future I want this to be configurable by user
			int morningHour = 9;

			if (remindTime.Value.Hour >= morningHour)
			{
				// Set time to morning, accounting for day rollover
				remindTime.Value = remindTime.Value.AddDays(1).Date + new TimeSpan(morningHour, 0, 0);
			}
			else
			{
				// Set time to morning
				remindTime.Value = remindTime.Value.Date + new TimeSpan(morningHour, 0, 0);
			}
		}

		private void submitReminder_btn_Click(object sender, EventArgs e)
		{
			// Read reminder data
			string reminder_message = createReminderGroup_reminderMessage.Text;
			DateTime reminder_time = remindTime.Value;
			bool reminder_allowSnoozing = true;

			// Validate user input to ensure reminder message isn't empty
			if (string.IsNullOrEmpty(reminder_message))
			{
				PopupForm form = new PopupForm("There is no message for the reminder. Is it supposed to tell you to do nothing?", "Oopsie!");
				form.ShowDialog();
			}
			// Validate user input to ensure reminder time is not a past time
			else if (remindTime.Value < DateTime.Now)
			{
				PopupForm form = new PopupForm("The time set for reminder has already passed. You must select a future time, ya goof!", "Whoops!");
				form.ShowDialog();
			}
			else
			{
				Button button = (Button)sender;

				// Create reminder
				if (button.Text.StartsWith("Remind"))
					frontToBack.CreateReminder(reminder_message, reminder_time, reminder_allowSnoozing);
				else if (button.Text.StartsWith("Edit"))
				{
					frontToBack.OnReminderUpdated(reminder_message, reminder_time, reminder_allowSnoozing);
					ShowCreateReminderPanel();
				}
			}
		}

		#endregion

		#region ReminderList

		public void RedrawRemindersList()
		{
			left_panel.Controls.Clear();
			DrawRemindersList();
		}

		private void DrawRemindersList()
		{
			var reminders = frontToBack.LoadReminders();
			int spaceBetweenEachReminder = 60;

			foreach (Reminder.ReminderData reminder in reminders)
			{
				string reminderMsg = reminder.Message;
				spaceBetweenEachReminder += -60;

				// Create button
				ComponentHelper.ButtonData buttonData = new ComponentHelper.ButtonData
				{
					BackgroundColor = Color.Gray,
					TextColor = Color.Black,
					FlatStyle = FlatStyle.Flat,
					Name = $"reminderBtn_{reminder.Id}",
					Text = $"{reminderMsg}\nReminds me at: {reminder.Time.ToLocalTime()}",
					TextAlign = ContentAlignment.MiddleCenter,
					Location = new Point(1, 19 - spaceBetweenEachReminder),
					Size = new Size(250, 55),
					Callback = OnReminderButtonClick
				};

				// Add button to controls
				Button button = ComponentHelper.CreateButton(buttonData);
				left_panel.Controls.Add(button);
			}
		}

		#endregion

		#region ReminderDetails

		// When reminder button is clicked, show details and edit/delete options
		private void OnReminderButtonClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			string id = button.Name.Substring(button.Name.Length - 36, 36);
			ShowReminderDetailsPanel(frontToBack.OnReminderSelected(id));
		}

		private void reminderDetails_editBtn_Click(object sender, EventArgs e)
        {
			ShowCreateReminderPanel();
			right_group.Text = "Edit reminder";
			createReminderGroup_submitReminder_btn.Text = "Edit";
        }

        private void reminderDetails_copyBtn_Click(object sender, EventArgs e)
        {
			frontToBack.OnReminderCopied();
        }

        private void reminderDetails_deleteBtn_Click(object sender, EventArgs e)
        {
			frontToBack.OnReminderDeleted();
			ShowCreateReminderPanel();
		}

        private void reminderDetails_goBackBtn_Click(object sender, EventArgs e)
        {
			ShowCreateReminderPanel();
        }

        #endregion

        #region NotificatonTray

        private void NotificationTrayIcon_DoubleClick(object sender, EventArgs e)
        {
			if (FormWindowState.Minimized == WindowState)
				ShowWindow(Handle, SW_RESTORE);
		}

        private void NotificationTrayIconContextMenu_Close_Click(object sender, EventArgs e)
        {
			Close();
        }

        #endregion
    }
}