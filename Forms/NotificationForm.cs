using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ForgetMeNot.Forms
{
    partial class NotificationForm : Form
    {
        public NotificationForm(Reminder.ReminderData reminder)
        {
            FiredReminder = reminder;
            InitializeComponent();
        }

        // Thanks to Kirtan Patel for this code to make window stay on top of all other windows
        // (https://www.c-sharpcorner.com/uploadfile/kirtan007/make-form-stay-always-on-top-of-every-window/)
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private const uint SWP_NOSIZE = 0x0001;
        private const uint SWP_NOMOVE = 0x0002;
        private const uint TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private Reminder.ReminderData FiredReminder { get; set; }

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            reminder_message.Text = FiredReminder.Message;
            //TopMost = true; // Set to above any other active window
            //SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            Activate();

            // Disable snooze button if snoozing disabled
            if (!FiredReminder.SnoozingAllowed)
            {
                snooze_btn.Enabled = false;
                snooze_btn.Visible = false;
                markAsDone_btn.Location = new System.Drawing.Point(Size.Width / 3, markAsDone_btn.Location.Y);
            }
        }

        private void markAsDone_btn_Click(object sender, EventArgs e)
        {
            DatabaseHandler.Instance.DeleteData(FiredReminder.Id);
            Reminder.Instance.Reminders.Remove(FiredReminder);
            MainForm.Instance.RedrawRemindersList();
            Close();
        }

        private void snooze_btn_Click(object sender, EventArgs e)
        {
            Debug.Log("Snooze clicked!");
            Close();
        }
    }
}