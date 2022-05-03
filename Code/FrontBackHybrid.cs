using System;
using System.Collections.Generic;

namespace ForgetMeNot
{
    class FrontBackHybrid
    {
        private readonly DatabaseHandler databaseHandler;
        private readonly Reminder reminderHandler;
        private Reminder.ReminderData selectedReminder;
        private MainForm mainForm;

        public FrontBackHybrid(MainForm form)
        {
            databaseHandler = DatabaseHandler.Instance;
            reminderHandler = Reminder.Instance;
            mainForm = form;
        }

        public List<Reminder.ReminderData> LoadReminders()
        {
            return reminderHandler.Reminders == null || reminderHandler.Reminders.Count < 1 ? 
                reminderHandler.LoadReminders() : reminderHandler.Reminders;
        }

        public void CreateReminder(string message, DateTime time, bool allowSnoozing)
        {
            reminderHandler.CreateNewReminder(message, time, allowSnoozing);
            mainForm.RedrawRemindersList();
        }

        public Reminder.ReminderData OnReminderSelected(int id)
        {
            selectedReminder = reminderHandler.Reminders.Find(x => x.Id == id);

            if (selectedReminder == null)
                Debug.Log($"Error: Failed to return a reminder with ID {id}. Returning null.");

            return selectedReminder;
        }

        public void OnReminderCopied()
        {
            //
        }

        public void OnReminderUpdated()
        {
            //
        }

        public void OnReminderDeleted()
        {
            if (selectedReminder != null)
            {
                databaseHandler.DeleteData(selectedReminder.Id);
                reminderHandler.Reminders.Remove(selectedReminder);
                mainForm.RedrawRemindersList();
            }
            else
                Debug.Log($"Error: Tried to delete null reminder.");
        }
    }
}