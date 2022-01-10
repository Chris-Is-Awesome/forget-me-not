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
			Reminder.OnButtonClicked();
		}
	}
}
