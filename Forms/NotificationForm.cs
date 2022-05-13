using System;
using System.Windows.Forms;

namespace ForgetMeNot.Forms
{
    partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        public Reminder.ReminderData Reminder { get; set; }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            reminder_message.Text = Reminder.Message;
            TopMost = true; // Set to above any other active window

            // Disable snooze button if snoozing disabled
            if (!Reminder.SnoozingAllowed)
            {
                snooze_btn.Enabled = false;
                snooze_btn.Visible = false;
                markAsDone_btn.Location = new System.Drawing.Point(Size.Width / 3, markAsDone_btn.Location.Y);
            }
        }

        private void markAsDone_btn_Click(object sender, EventArgs e)
        {
            Debug.Log("Mark as done clicked!");
        }

        private void snooze_btn_Click(object sender, EventArgs e)
        {
            Debug.Log("Snooze clicked!");
        }
    }
}