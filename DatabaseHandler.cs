using System.Data;
using System.Data.SqlClient;

namespace ForgetMeNot
{
    class DatabaseHandler
    {
		private readonly string tableName = "tbl_Reminders";

		public DataTable LoadDatabase()
		{
			string connectionStr = Properties.Settings.Default.dbRemindersConnectionString;
			SqlConnection connection = new SqlConnection(connectionStr);

			if (connection.State != ConnectionState.Open)
				connection.Open();

			string command = $"SELECT * FROM {tableName}";
			DataTable table = new DataTable();
			SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
			adapter.Fill(table);

			return table;
		}
	}
}
