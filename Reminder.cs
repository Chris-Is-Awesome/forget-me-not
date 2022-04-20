using System;
using System.Collections.Generic;
using System.Data;

namespace ForgetMeNot
{
	class Reminder
	{
		struct ReminderData
		{
			public string Message { get; set; }
			public DateTime Time { get; set; }
			public bool SnoozingAllowed { get; set; }
		}

		private static List<ReminderData> allReminders = new List<ReminderData>();

		public static void LoadReminders(DataTable table)
        {
			//
        }

		public void CreateNewReminder(string message, DateTime time, bool snoozingAllowed)
		{
			// Create new reminder
			ReminderData newReminder = new ReminderData
			{
				Message = message,
				Time = time,
				SnoozingAllowed = snoozingAllowed
			};

			// Add reminder to list of active reminders
			allReminders.Add(newReminder);

			// TODO: Add to database so it persists through sessions
			Console.WriteLine("Reminder created! Time to add it to a database!");
		}
	}
}