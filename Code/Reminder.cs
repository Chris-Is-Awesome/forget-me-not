﻿using System;
using System.Collections.Generic;
using System.Data;

namespace ForgetMeNot
{
	class Reminder
	{
		private Reminder() { }

		private static Reminder _instance;
		private readonly DatabaseHandler databaseHandler = new DatabaseHandler();
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
				string message = row["Message"].ToString();
				//DateTime time = DateTime.Parse(row["Time"].ToString());
				DateTime time = DateTime.Now;
				bool allowSnoozing = bool.Parse(row["SnoozingAllowed"].ToString());
				ReminderData reminder = new ReminderData(i, message, time, allowSnoozing);
				_allReminders.Add(reminder);

				Console.WriteLine($"Loaded reminder: {message.Trim()}");
			}

			return _allReminders;
        }

		public void CreateNewReminder(string message, DateTime time, bool snoozingAllowed)
		{
			// Create new reminder
			ReminderData newReminder = new ReminderData(_allReminders.Count + 1, message, time, snoozingAllowed);

			// Add reminder to list of active reminders
			_allReminders.Add(newReminder);

			// TODO: Add to database so it persists through sessions
			Console.WriteLine("Reminder created! Time to add it to a database!");
		}

		public class ReminderData
		{
			public int Id { get; }
			public string Message { get; }
			public DateTime Time { get; }
			public bool SnoozingAllowed { get; }

			public ReminderData(int id, string message, DateTime time, bool snoozingAllowed)
			{
				Id = id;
				Message = message;
				Time = time;
				SnoozingAllowed = snoozingAllowed;
			}
		}
	}
}