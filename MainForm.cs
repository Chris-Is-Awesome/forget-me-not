using System;
using System.Windows.Forms;

namespace ForgetMeNot
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void createReminderBtn_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Create reminder button clicked!");
			ShowReminderCreateGroup();
		}

		DateTimePicker remindTimePicker;

		private void ShowReminderCreateGroup()
		{
			createReminder_group.Visible = true;

			remindTimePicker = createReminder_dateTimePicker;
			remindTimePicker.Format = DateTimePickerFormat.Custom;
		}

		private void remindIn30Minutes_btn_Click(object sender, EventArgs e)
		{
			remindTimePicker.Value = remindTimePicker.Value.AddMinutes(30);
		}

		private void remindIn1Hour_btn_Click(object sender, EventArgs e)
		{
			remindTimePicker.Value = remindTimePicker.Value.AddHours(1);
		}

		private void remindIn6Hours_btn_Click(object sender, EventArgs e)
		{
			remindTimePicker.Value = remindTimePicker.Value.AddHours(6);
		}

		private void remindInMorning_btn_Click(object sender, EventArgs e)
		{
			// TEMP: Hardcode "morning" time. In the future I want this to be configurable by user
			int morningHour = 9;

			if (remindTimePicker.Value.Hour >= morningHour)
			{
				// Set time to morning, accounting for day rollover
				remindTimePicker.Value = remindTimePicker.Value.AddDays(1).Date + new TimeSpan(morningHour, 0, 0);
			}
			else
			{
				// Set time to morning
				remindTimePicker.Value = remindTimePicker.Value.Date + new TimeSpan(morningHour, 0, 0);
			}
		}
	}
}
