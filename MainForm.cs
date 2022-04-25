using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ForgetMeNot
{
	public partial class MainForm : Form
	{
		Reminder reminderHandler = new Reminder();
		DatabaseHandler databaseHandler = new DatabaseHandler();

		public MainForm()
		{
			InitializeComponent();
			ShowCreateReminderPanel();
		}

		DateTimePicker remindTime;

		private void ShowCreateReminderPanel()
		{
			// Toggle panels
			createReminder_panel.Visible = true;
			reminderDetails_panel.Visible = false;
			right_group.Text = "Create reminder";

			// Set custom format for date time picker
			remindTime = createReminderGroup_remindTime;
			remindTime.Format = DateTimePickerFormat.Custom;

			// Set start time to be 1 hour ahead of current time
			remindTime.MinDate = DateTime.Now;
			remindTime.Value = remindTime.MinDate.AddHours(1);
		}

		private void ShowReminderDetailsPanel(Reminder.ReminderData reminder)
        {
			// Toggle panels
			createReminder_panel.Visible = false;
			reminderDetails_panel.Visible = true;
			right_group.Text = "Reminder details";

			// Show reminder details
			reminderDetails_message.Text = reminder.Message;
		}

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
			if  (string.IsNullOrEmpty(reminder_message))
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
				// Create reminder
				reminderHandler.CreateNewReminder(reminder_message, reminder_time, reminder_allowSnoozing);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			var reminders = reminderHandler.LoadReminders();
			int spaceBetweenEachReminder = 60;

			for (int i = 0; i < reminders.Count; i++)
			{
				spaceBetweenEachReminder += -60;
				string reminderMsg = reminders[i].Message.ToString();

				// Create button
				ComponentHelper.ButtonData buttonData = new ComponentHelper.ButtonData
				{
					BackgroundColor = Color.Gray,
					TextColor = Color.Black,
					FlatStyle = FlatStyle.Flat,
					Name = $"reminderBtn_{i}",
					Text = $"{reminderMsg}\nReminds me at: {reminders[i].Time}",
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

		// When reminder button is clicked, show details and edit/delete options
		private void OnReminderButtonClick(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			int id = int.Parse(button.Name[button.Name.Length - 1].ToString());
			Reminder.ReminderData reminder = reminderHandler.Reminders.Find(x => x.Id == id);

			if (reminder != null)
				ShowReminderDetailsPanel(reminder);
			else
				Console.WriteLine($"Something went wrong! Button {button.Name} did not return ReminderData!");
		}
    }
}
