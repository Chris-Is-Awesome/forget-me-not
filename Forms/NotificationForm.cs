using Plugin.SimpleAudioPlayer;
using System;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ForgetMeNot.Forms
{
    partial class NotificationForm : Form
    {
        public NotificationForm(Reminder.ReminderData reminder)
        {
            this.reminder = reminder;
            InitializeComponent();
        }

        private Reminder.ReminderData reminder;
        private DateTime remindTime;

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            // Disable main window control (avoids many potential issues)
            Invoke(new Action(() => { MainForm.Instance.Enabled = false; }));

            // Set reminder text
            reminder_message.Text = reminder.Message;

            // Disable snooze interface if snoozing disabled
            if (!reminder.SnoozingAllowed)
            {
                snooze_btn.Enabled = false;
                snooze_btn.Visible = false;
                snoozeTime.Enabled = false;
                snoozeTime.Visible = false;
                markAsDone_btn.Location = new System.Drawing.Point(Size.Width / 3, markAsDone_btn.Location.Y);
            }
            else
                snoozeTime.SelectedIndex = 0;

            Activate();
            PlayRingtone();
        }

        private void PlayRingtone()
        {
            ISimpleAudioPlayer player = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            player.Load(Utility.GetStreamFromFile("Audio/Ringtones/Hornet.mp3"));
            player.Play();
        }

        private void markAsDone_btn_Click(object sender, EventArgs e)
        {
            // Delete reminder
            DatabaseHandler.Instance.DeleteData(reminder.Id);
            Reminder.Instance.Reminders.Remove(reminder);
            MainForm.Instance.RedrawRemindersList();

            CloseWindow();
        }

        private void snoozeTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string time = snoozeTime.SelectedItem.ToString();
            string[] numbers = Regex.Split(time, @"\D+");

            if (char.IsDigit(time[0]))
            {
                int amount = int.Parse(string.Join("", numbers));

                // If snoozing for minutes
                if (time.Contains("minute"))
                    remindTime = currentTime.AddMinutes(amount);
                // If snoozing for hours
                else if (time.Contains("hour"))
                    remindTime = currentTime.AddHours(amount);
            }
            // If snoozing until tomorrow
            else if (time.EndsWith("tomorrow"))
                remindTime = currentTime.AddDays(1);

            // Update button text to show remind time
            snooze_btn.Text = $"Snooze until\n{remindTime}";
        }

        private void snooze_btn_Click(object sender, EventArgs e)
        {
            // Snooze reminder
            reminder.ChangeTime(remindTime);
            reminder.HasFired = false;
            DatabaseHandler.Instance.UpdateData(reminder);
            int index = Reminder.Instance.Reminders.FindIndex(x => x.Id == reminder.Id);
            Reminder.Instance.Reminders[index] = reminder;
            MainForm.Instance.RedrawRemindersList();

            CloseWindow();
        }

        private void CloseWindow()
        {
            // Re-enable main window control
            Invoke(new Action(() => { MainForm.Instance.Enabled = true; }));
            Close();
        }
    }
}