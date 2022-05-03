using System;
using System.Windows.Forms;

namespace ForgetMeNot
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Debug.Log($"===== PROGRAM STARTED AT {DateTime.Now} =====", false);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
