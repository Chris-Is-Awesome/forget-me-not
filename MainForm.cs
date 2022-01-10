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

		private void ShowReminderCreateGroup()
		{
			createReminder_group.Visible = true;

			DateTimePicker timePicker = createReminder_timePicker;
			timePicker.Format = DateTimePickerFormat.Time;
			timePicker.ShowUpDown = true;
		}

		private void remindIn30Minutes_btn_Click(object sender, EventArgs e)
		{
			DateTimePicker datePicker = createReminder_datePicker;
			DateTimePicker timePicker = createReminder_timePicker;
			datePicker.Value = datePicker.Value.AddMinutes(30);
			timePicker.Value = timePicker.Value.AddMinutes(30);
		}
	}
}
