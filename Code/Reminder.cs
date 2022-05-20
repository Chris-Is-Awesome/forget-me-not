using System;
using System.Collections.Generic;
using System.Data;

namespace ForgetMeNot
{
	class Reminder
	{
		private Reminder() { }

		private static Reminder _instance;
		private readonly DatabaseHandler databaseHandler = DatabaseHandler.Instance;
		private readonly List<ReminderData> _allReminders = new List<ReminderData>();

		public static Reminder Instance
        {
			get
            {
				if (_instance == null)
					_instance = new Reminder();
				return _instance;
            }
        }
		public List<ReminderData> Reminders { get { return _allReminders; } }

		public List<ReminderData> LoadReminders()
        {
			DataTable table = databaseHandler.LoadDatabase();
			
			for (int i = 0; i < table.Rows.Count; i++)
			{
				DataRow row = table.Rows[i];
				string id = row["Id"].ToString();
				string message = row["Message"].ToString();
				DateTime time = DateTime.Parse(row["Time"].ToString()).ToLocalTime();
				bool allowSnoozing = bool.Parse(row["SnoozingAllowed"].ToString());
				DateTime createdAt = DateTime.Parse(row["CreatedAt"].ToString()).ToLocalTime();
				ReminderData reminder = new ReminderData(id, message, time, allowSnoozing, createdAt);
				_allReminders.Add(reminder);
			}

			return _allReminders;
        }

		public void CreateNewReminder(string message, DateTime time, bool snoozingAllowed)
		{
			// Get unique ID
			string id = Guid.NewGuid().ToString();

			// Create reminder
			ReminderData newReminder = new ReminderData(id, message, time, snoozingAllowed, DateTime.Now);

			// Add reminder to list of active reminders
			_allReminders.Add(newReminder);

			// Add reminder to database
			databaseHandler.AddData(newReminder);
		}

		public class ReminderData
		{
			public string Id { get; }
			public string Message { get; }
			public DateTime Time { get; }
			public bool SnoozingAllowed { get; }
			public DateTime CreatedAt { get; }
			public bool HasFired { get; set; }

			public ReminderData(string id, string message, DateTime time, bool snoozingAllowed, DateTime createdAt)
			{
				Id = id;
				Message = message;
				Time = time.AddSeconds(-time.Second).ToUniversalTime(); // Remove seconds from time & convert to UTC
				SnoozingAllowed = snoozingAllowed;
				CreatedAt = createdAt.ToUniversalTime();
			}
		}
	}
}