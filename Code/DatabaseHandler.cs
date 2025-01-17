﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace ForgetMeNot
{
    class DatabaseHandler
    {
		private static DatabaseHandler _instance;
		private SqlConnection _connection;

		public static DatabaseHandler Instance
        {
            get
            {
				if (_instance == null)
					_instance = new DatabaseHandler();
				return _instance;
            }
        }
		private string TableName { get { return "tbl_Reminders"; } }
		private SqlConnection Connection
        {
			get
            {
				if (_connection == null)
                {
					string connectionStr = Properties.Settings.Default.reminderDataConnectionString;
					_connection = new SqlConnection(connectionStr);
				}

				return _connection;
            }
        }

		public DataTable LoadDatabase()
		{
			DataTable table = new DataTable();

			try
            {
				string sql = $"SELECT * FROM {TableName}";

				using (SqlDataAdapter adapter = new SqlDataAdapter(sql, Connection))
                {
					adapter.Fill(table);
                }
			}
			catch (Exception ex)
            {
				Debug.LogError(ex.Message);
            }

			return table;
		}

		public void AddData(Reminder.ReminderData reminder)
		{
			try
			{
				string sql = $"INSERT INTO {TableName} (Id, Message, Time, SnoozingAllowed, CreatedAt) VALUES (@Id, @Message, @Time, @SnoozingAllowed, @CreatedAt)";

				using (SqlCommand cmd = new SqlCommand(sql, Connection))
				{
					cmd.Parameters.AddWithValue("@Id", reminder.Id);
					cmd.Parameters.AddWithValue("@Message", reminder.Message);
					cmd.Parameters.AddWithValue("@Time", reminder.Time);
					cmd.Parameters.AddWithValue("@SnoozingAllowed", reminder.SnoozingAllowed);
					cmd.Parameters.AddWithValue("@CreatedAt", reminder.CreatedAt);
					Connection.Open();
					cmd.ExecuteNonQuery();
				}
			}
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
			}
			finally
			{
				Connection.Close();
			}
		}

		public void DeleteData(string id)
        {
			try
            {
				string sql = $"DELETE FROM {TableName} WHERE Id='{id}'";

				using (SqlCommand cmd = new SqlCommand(sql, Connection))
                {
					Connection.Open();
					cmd.ExecuteNonQuery();
                }
            }
			catch (Exception ex)
			{
				Debug.LogError(ex.Message);
			}
			finally
			{
				Connection.Close();
			}
		}

		public void UpdateData(Reminder.ReminderData reminder)
        {
			string sql = string.Concat(
					$"UPDATE {TableName} SET ",
					$"Message='{reminder.Message}', ",
					$"Time='{reminder.Time}', ",
					$"SnoozingAllowed='{reminder.SnoozingAllowed}', ",
					$"CreatedAt='{DateTime.Now}' ",
					$"WHERE Id='{reminder.Id}'");

			try
            {
				using (SqlCommand cmd = new SqlCommand(sql, Connection))
                {
					Connection.Open();
					cmd.ExecuteNonQuery();
                }
            }
			catch (Exception ex)
            {
				Debug.LogError($"SQL command '{sql}' failed:\n{ex.Message}");
            }
			finally
            {
				Connection.Close();
			}
        }
	}
}
