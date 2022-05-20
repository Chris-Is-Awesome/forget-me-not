using ForgetMeNot.Forms;
using System;
using System.Threading;

namespace ForgetMeNot
{
    class NotificationHandler
    {
        private static NotificationHandler _instance;
        private Reminder reminderHandler;
        private Timer timer;

        public static NotificationHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NotificationHandler();

                return _instance;
            }
        }

        public void StartTimer()
        {
            reminderHandler = Reminder.Instance;
            TimeSpan interval = TimeSpan.FromSeconds(1);

            // Start timer
            timer = new Timer((e) =>
            {
                CheckReminderTimes();
            }, null, TimeSpan.Zero, interval);
        }
        
        private void CheckReminderTimes()
        {
            for (int i = 0; i < reminderHandler.Reminders.Count; i++)
            {
                Reminder.ReminderData reminder = reminderHandler.Reminders[i];

                // If has not fired already
                if (!reminder.HasFired)
                {
                    // If reminder time has passed
                    if (DateTime.Now.ToUniversalTime() >= reminder.Time)
                    {
                        // Fire notification
                        FireNotification(reminder);
                    }
                    else
                    {
                        Debug.Log($"Not to run yet...\n{DateTime.Now.TimeOfDay} < {reminder.Time.ToLocalTime().TimeOfDay}");
                    }
                }
            }
        }

        private void FireNotification(Reminder.ReminderData reminder)
        {
            // Prevent reminder from re-firing notification
            reminder.HasFired = true;

            // Show notification
            NotificationForm notif = new NotificationForm(reminder);
            notif.ShowDialog();
        }
    }
}