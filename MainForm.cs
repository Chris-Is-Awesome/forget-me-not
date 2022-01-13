using System;
using System.Windows.Forms;

namespace ForgetMeNot
{
	public partial class MainForm : Form
	{
		Reminder reminderHandler = new Reminder();

		public MainForm()
		{
			InitializeComponent();
		}

		private void createReminderBtn_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Create reminder button clicked!");
			ShowCreateReminderGroup();
		}

		DateTimePicker remindTime;

		private void ShowCreateReminderGroup()
		{
			// Show group & hide initial button
			createReminder_btn.Visible = false;
			createReminder_group.Visible = true;

			// Set custom format for date time picker
			remindTime = createReminderGroup_remindTime;
			remindTime.Format = DateTimePickerFormat.Custom;

			// Set start time to be 1 hour ahead of current time
			remindTime.MinDate = DateTime.Now;
			remindTime.Value = remindTime.MinDate.AddHours(1);
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

				// Close create reminder group & show the button to create another
				createReminder_group.Visible = false;
				createReminder_btn.Visible = true;
			}
		}
	}
}
