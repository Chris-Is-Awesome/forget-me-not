using System;
using System.Data;
using System.Data.SqlClient;

namespace ForgetMeNot
{
    class DatabaseHandler
    {
		private readonly string tableName = "tbl_Reminders";

		public DataTable LoadDatabase()
		{
			SqlConnection connection = GetConnection();
			string command = $"SELECT * FROM {tableName}";
			DataTable table = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
			adapter.Fill(table);

			connection.Close();
			return table;
		}

		public void AddData(Reminder.ReminderData reminder)
        {
			/*
			SqlConnection connection = GetConnection();
			string command = $"INSERT INTO {tableName} VALUES ({reminder.Message}, {reminder.Time}, {reminder.SnoozingAllowed})";
			DataTable table = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
			adapter.Update(table);

			connection.Close();
			*/

			SqlConnection connection = GetConnection();
			
			try
            {
				string sql = $"INSERT INTO {tableName} (Id, Message, Time, SnoozingAllowed) VALUES (@Id, @Message, @Time, @SnoozingAllowed)";

				using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
					connection.Open();
					cmd.Parameters.Add("@Id", SqlDbType.Int);
					cmd.Parameters["@Id"].Value = reminder.Id;
					cmd.Parameters.Add("@Message", SqlDbType.Text);
					cmd.Parameters["@Message"].Value = reminder.Message;
					cmd.Parameters.Add("@Time", SqlDbType.DateTime);
					cmd.Parameters["@Time"].Value = reminder.Time;
					cmd.Parameters.Add("@SnoozingAllowed", SqlDbType.Bit);
					cmd.Parameters["@SnoozingAllowed"].Value = 1;
					Console.WriteLine(cmd.ExecuteNonQuery());
					Console.WriteLine("Success!");
                }
            }
			catch (Exception ex)
            {
				Console.WriteLine($"EXCEPTION: {ex.Message}");
            }
			finally
            {
				connection.Close();
				Console.WriteLine("Closed!");
            }
		}

		private SqlConnection GetConnection()
        {
			string connectionStr = Properties.Settings.Default.reminderDataConnectionString;
			SqlConnection connection = new SqlConnection(connectionStr);

			/*
			if (connection.State != ConnectionState.Open)
				connection.Open();
			*/

			return connection;
		}
	}
}
