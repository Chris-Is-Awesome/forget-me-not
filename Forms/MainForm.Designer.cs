
namespace ForgetMeNot
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.message_header = new System.Windows.Forms.Label();
            this.createReminderGroup_submitReminder_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_remindTime = new System.Windows.Forms.DateTimePicker();
            this.createReminderGroup_remindInMorning_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_remindIn6Hours_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_remindIn1Hour_btn = new System.Windows.Forms.Button();
            this.time_header = new System.Windows.Forms.Label();
            this.createReminderGroup_remindIn30Minutes_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_reminderMessage = new System.Windows.Forms.TextBox();
            this.left_group = new System.Windows.Forms.GroupBox();
            this.left_panel = new System.Windows.Forms.Panel();
            this.left_scroll = new System.Windows.Forms.VScrollBar();
            this.createReminder_panel = new System.Windows.Forms.Panel();
            this.right_group = new System.Windows.Forms.GroupBox();
            this.reminderDetails_panel = new System.Windows.Forms.Panel();
            this.reminderDetails_goBackBtn = new System.Windows.Forms.Button();
            this.reminderDetails_deleteBtn = new System.Windows.Forms.Button();
            this.reminderDetails_copyBtn = new System.Windows.Forms.Button();
            this.reminderDetails_editBtn = new System.Windows.Forms.Button();
            this.reminderDetails_isSnoozeable = new System.Windows.Forms.Label();
            this.reminderDetails_createdAtTime = new System.Windows.Forms.Label();
            this.reminderDetails_remindTime = new System.Windows.Forms.Label();
            this.reminderDetails_message = new System.Windows.Forms.Label();
            this.NotificationTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotificationTrayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.left_panel.SuspendLayout();
            this.createReminder_panel.SuspendLayout();
            this.right_group.SuspendLayout();
            this.reminderDetails_panel.SuspendLayout();
            this.NotificationTrayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // message_header
            // 
            this.message_header.AutoSize = true;
            this.message_header.ForeColor = System.Drawing.Color.Black;
            this.message_header.Location = new System.Drawing.Point(92, 9);
            this.message_header.Name = "message_header";
            this.message_header.Size = new System.Drawing.Size(81, 13);
            this.message_header.TabIndex = 7;
            this.message_header.Text = "Remind me to...";
            // 
            // createReminderGroup_submitReminder_btn
            // 
            this.createReminderGroup_submitReminder_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminderGroup_submitReminder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReminderGroup_submitReminder_btn.ForeColor = System.Drawing.Color.Black;
            this.createReminderGroup_submitReminder_btn.Location = new System.Drawing.Point(94, 205);
            this.createReminderGroup_submitReminder_btn.Name = "createReminderGroup_submitReminder_btn";
            this.createReminderGroup_submitReminder_btn.Size = new System.Drawing.Size(75, 23);
            this.createReminderGroup_submitReminder_btn.TabIndex = 6;
            this.createReminderGroup_submitReminder_btn.Text = "Remind me!";
            this.createReminderGroup_submitReminder_btn.UseVisualStyleBackColor = false;
            this.createReminderGroup_submitReminder_btn.Click += new System.EventHandler(this.submitReminder_btn_Click);
            // 
            // createReminderGroup_remindTime
            // 
            this.createReminderGroup_remindTime.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createReminderGroup_remindTime.CustomFormat = "MM/dd/yyyy @ hh:mm tt";
            this.createReminderGroup_remindTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createReminderGroup_remindTime.Location = new System.Drawing.Point(29, 179);
            this.createReminderGroup_remindTime.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.createReminderGroup_remindTime.Name = "createReminderGroup_remindTime";
            this.createReminderGroup_remindTime.Size = new System.Drawing.Size(201, 20);
            this.createReminderGroup_remindTime.TabIndex = 3;
            this.createReminderGroup_remindTime.Value = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            // 
            // createReminderGroup_remindInMorning_btn
            // 
            this.createReminderGroup_remindInMorning_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminderGroup_remindInMorning_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReminderGroup_remindInMorning_btn.ForeColor = System.Drawing.Color.Black;
            this.createReminderGroup_remindInMorning_btn.Location = new System.Drawing.Point(155, 150);
            this.createReminderGroup_remindInMorning_btn.Name = "createReminderGroup_remindInMorning_btn";
            this.createReminderGroup_remindInMorning_btn.Size = new System.Drawing.Size(75, 23);
            this.createReminderGroup_remindInMorning_btn.TabIndex = 5;
            this.createReminderGroup_remindInMorning_btn.Text = "Morning";
            this.createReminderGroup_remindInMorning_btn.UseVisualStyleBackColor = false;
            this.createReminderGroup_remindInMorning_btn.Click += new System.EventHandler(this.remindInMorning_btn_Click);
            // 
            // createReminderGroup_remindIn6Hours_btn
            // 
            this.createReminderGroup_remindIn6Hours_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminderGroup_remindIn6Hours_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReminderGroup_remindIn6Hours_btn.ForeColor = System.Drawing.Color.Black;
            this.createReminderGroup_remindIn6Hours_btn.Location = new System.Drawing.Point(29, 150);
            this.createReminderGroup_remindIn6Hours_btn.Name = "createReminderGroup_remindIn6Hours_btn";
            this.createReminderGroup_remindIn6Hours_btn.Size = new System.Drawing.Size(75, 23);
            this.createReminderGroup_remindIn6Hours_btn.TabIndex = 4;
            this.createReminderGroup_remindIn6Hours_btn.Text = "6 hours";
            this.createReminderGroup_remindIn6Hours_btn.UseVisualStyleBackColor = false;
            this.createReminderGroup_remindIn6Hours_btn.Click += new System.EventHandler(this.remindIn6Hours_btn_Click);
            // 
            // createReminderGroup_remindIn1Hour_btn
            // 
            this.createReminderGroup_remindIn1Hour_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminderGroup_remindIn1Hour_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReminderGroup_remindIn1Hour_btn.ForeColor = System.Drawing.Color.Black;
            this.createReminderGroup_remindIn1Hour_btn.Location = new System.Drawing.Point(155, 121);
            this.createReminderGroup_remindIn1Hour_btn.Name = "createReminderGroup_remindIn1Hour_btn";
            this.createReminderGroup_remindIn1Hour_btn.Size = new System.Drawing.Size(75, 23);
            this.createReminderGroup_remindIn1Hour_btn.TabIndex = 3;
            this.createReminderGroup_remindIn1Hour_btn.Text = "1 hour";
            this.createReminderGroup_remindIn1Hour_btn.UseVisualStyleBackColor = false;
            this.createReminderGroup_remindIn1Hour_btn.Click += new System.EventHandler(this.remindIn1Hour_btn_Click);
            // 
            // time_header
            // 
            this.time_header.AutoSize = true;
            this.time_header.ForeColor = System.Drawing.Color.Black;
            this.time_header.Location = new System.Drawing.Point(110, 97);
            this.time_header.Name = "time_header";
            this.time_header.Size = new System.Drawing.Size(38, 13);
            this.time_header.TabIndex = 2;
            this.time_header.Text = "in/at...";
            // 
            // createReminderGroup_remindIn30Minutes_btn
            // 
            this.createReminderGroup_remindIn30Minutes_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminderGroup_remindIn30Minutes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReminderGroup_remindIn30Minutes_btn.ForeColor = System.Drawing.Color.Black;
            this.createReminderGroup_remindIn30Minutes_btn.Location = new System.Drawing.Point(29, 121);
            this.createReminderGroup_remindIn30Minutes_btn.Name = "createReminderGroup_remindIn30Minutes_btn";
            this.createReminderGroup_remindIn30Minutes_btn.Size = new System.Drawing.Size(75, 23);
            this.createReminderGroup_remindIn30Minutes_btn.TabIndex = 1;
            this.createReminderGroup_remindIn30Minutes_btn.Text = "30 minutes";
            this.createReminderGroup_remindIn30Minutes_btn.UseVisualStyleBackColor = false;
            this.createReminderGroup_remindIn30Minutes_btn.Click += new System.EventHandler(this.remindIn30Minutes_btn_Click);
            // 
            // createReminderGroup_reminderMessage
            // 
            this.createReminderGroup_reminderMessage.AcceptsReturn = true;
            this.createReminderGroup_reminderMessage.AllowDrop = true;
            this.createReminderGroup_reminderMessage.BackColor = System.Drawing.Color.DarkGray;
            this.createReminderGroup_reminderMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createReminderGroup_reminderMessage.Location = new System.Drawing.Point(3, 25);
            this.createReminderGroup_reminderMessage.Multiline = true;
            this.createReminderGroup_reminderMessage.Name = "createReminderGroup_reminderMessage";
            this.createReminderGroup_reminderMessage.Size = new System.Drawing.Size(262, 65);
            this.createReminderGroup_reminderMessage.TabIndex = 0;
            // 
            // left_group
            // 
            this.left_group.Location = new System.Drawing.Point(12, 12);
            this.left_group.Name = "left_group";
            this.left_group.Size = new System.Drawing.Size(280, 362);
            this.left_group.TabIndex = 3;
            this.left_group.TabStop = false;
            this.left_group.Text = "Reminders";
            // 
            // left_panel
            // 
            this.left_panel.BackColor = System.Drawing.Color.Transparent;
            this.left_panel.Controls.Add(this.left_scroll);
            this.left_panel.Location = new System.Drawing.Point(18, 25);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(268, 343);
            this.left_panel.TabIndex = 0;
            // 
            // left_scroll
            // 
            this.left_scroll.Location = new System.Drawing.Point(256, 0);
            this.left_scroll.Name = "left_scroll";
            this.left_scroll.Size = new System.Drawing.Size(12, 343);
            this.left_scroll.TabIndex = 0;
            // 
            // createReminder_panel
            // 
            this.createReminder_panel.BackColor = System.Drawing.Color.Transparent;
            this.createReminder_panel.Controls.Add(this.message_header);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_reminderMessage);
            this.createReminder_panel.Controls.Add(this.time_header);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_submitReminder_btn);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_remindIn30Minutes_btn);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_remindIn1Hour_btn);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_remindTime);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_remindIn6Hours_btn);
            this.createReminder_panel.Controls.Add(this.createReminderGroup_remindInMorning_btn);
            this.createReminder_panel.Location = new System.Drawing.Point(0, 0);
            this.createReminder_panel.Name = "createReminder_panel";
            this.createReminder_panel.Size = new System.Drawing.Size(268, 343);
            this.createReminder_panel.TabIndex = 4;
            // 
            // right_group
            // 
            this.right_group.Controls.Add(this.reminderDetails_panel);
            this.right_group.Location = new System.Drawing.Point(304, 12);
            this.right_group.Name = "right_group";
            this.right_group.Size = new System.Drawing.Size(280, 362);
            this.right_group.TabIndex = 5;
            this.right_group.TabStop = false;
            this.right_group.Text = "Create Reminder";
            // 
            // reminderDetails_panel
            // 
            this.reminderDetails_panel.BackColor = System.Drawing.Color.Transparent;
            this.reminderDetails_panel.Controls.Add(this.createReminder_panel);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_goBackBtn);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_deleteBtn);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_copyBtn);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_editBtn);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_isSnoozeable);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_createdAtTime);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_remindTime);
            this.reminderDetails_panel.Controls.Add(this.reminderDetails_message);
            this.reminderDetails_panel.Location = new System.Drawing.Point(6, 13);
            this.reminderDetails_panel.Name = "reminderDetails_panel";
            this.reminderDetails_panel.Size = new System.Drawing.Size(268, 343);
            this.reminderDetails_panel.TabIndex = 8;
            this.reminderDetails_panel.Visible = false;
            // 
            // reminderDetails_goBackBtn
            // 
            this.reminderDetails_goBackBtn.BackColor = System.Drawing.Color.Gray;
            this.reminderDetails_goBackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderDetails_goBackBtn.ForeColor = System.Drawing.Color.Black;
            this.reminderDetails_goBackBtn.Location = new System.Drawing.Point(108, 202);
            this.reminderDetails_goBackBtn.Name = "reminderDetails_goBackBtn";
            this.reminderDetails_goBackBtn.Size = new System.Drawing.Size(58, 23);
            this.reminderDetails_goBackBtn.TabIndex = 7;
            this.reminderDetails_goBackBtn.Text = "Go back";
            this.reminderDetails_goBackBtn.UseVisualStyleBackColor = false;
            this.reminderDetails_goBackBtn.Click += new System.EventHandler(this.reminderDetails_goBackBtn_Click);
            // 
            // reminderDetails_deleteBtn
            // 
            this.reminderDetails_deleteBtn.BackColor = System.Drawing.Color.Gray;
            this.reminderDetails_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderDetails_deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.reminderDetails_deleteBtn.Location = new System.Drawing.Point(198, 162);
            this.reminderDetails_deleteBtn.Name = "reminderDetails_deleteBtn";
            this.reminderDetails_deleteBtn.Size = new System.Drawing.Size(58, 23);
            this.reminderDetails_deleteBtn.TabIndex = 6;
            this.reminderDetails_deleteBtn.Text = "Delete";
            this.reminderDetails_deleteBtn.UseVisualStyleBackColor = false;
            this.reminderDetails_deleteBtn.Click += new System.EventHandler(this.reminderDetails_deleteBtn_Click);
            // 
            // reminderDetails_copyBtn
            // 
            this.reminderDetails_copyBtn.BackColor = System.Drawing.Color.Gray;
            this.reminderDetails_copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderDetails_copyBtn.ForeColor = System.Drawing.Color.Black;
            this.reminderDetails_copyBtn.Location = new System.Drawing.Point(108, 162);
            this.reminderDetails_copyBtn.Name = "reminderDetails_copyBtn";
            this.reminderDetails_copyBtn.Size = new System.Drawing.Size(58, 23);
            this.reminderDetails_copyBtn.TabIndex = 5;
            this.reminderDetails_copyBtn.Text = "Copy";
            this.reminderDetails_copyBtn.UseVisualStyleBackColor = false;
            this.reminderDetails_copyBtn.Click += new System.EventHandler(this.reminderDetails_copyBtn_Click);
            // 
            // reminderDetails_editBtn
            // 
            this.reminderDetails_editBtn.BackColor = System.Drawing.Color.Gray;
            this.reminderDetails_editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderDetails_editBtn.ForeColor = System.Drawing.Color.Black;
            this.reminderDetails_editBtn.Location = new System.Drawing.Point(19, 162);
            this.reminderDetails_editBtn.Name = "reminderDetails_editBtn";
            this.reminderDetails_editBtn.Size = new System.Drawing.Size(58, 23);
            this.reminderDetails_editBtn.TabIndex = 4;
            this.reminderDetails_editBtn.Text = "Edit";
            this.reminderDetails_editBtn.UseVisualStyleBackColor = false;
            this.reminderDetails_editBtn.Click += new System.EventHandler(this.reminderDetails_editBtn_Click);
            // 
            // reminderDetails_isSnoozeable
            // 
            this.reminderDetails_isSnoozeable.AutoSize = true;
            this.reminderDetails_isSnoozeable.Location = new System.Drawing.Point(6, 121);
            this.reminderDetails_isSnoozeable.Name = "reminderDetails_isSnoozeable";
            this.reminderDetails_isSnoozeable.Size = new System.Drawing.Size(96, 13);
            this.reminderDetails_isSnoozeable.TabIndex = 3;
            this.reminderDetails_isSnoozeable.Text = "Is snoozeable: Yes";
            this.reminderDetails_isSnoozeable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reminderDetails_createdAtTime
            // 
            this.reminderDetails_createdAtTime.AutoSize = true;
            this.reminderDetails_createdAtTime.Location = new System.Drawing.Point(6, 97);
            this.reminderDetails_createdAtTime.Name = "reminderDetails_createdAtTime";
            this.reminderDetails_createdAtTime.Size = new System.Drawing.Size(169, 13);
            this.reminderDetails_createdAtTime.TabIndex = 2;
            this.reminderDetails_createdAtTime.Text = "Created at: 11/11/11 at 11:11 PM";
            this.reminderDetails_createdAtTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reminderDetails_remindTime
            // 
            this.reminderDetails_remindTime.AutoSize = true;
            this.reminderDetails_remindTime.Location = new System.Drawing.Point(6, 76);
            this.reminderDetails_remindTime.Name = "reminderDetails_remindTime";
            this.reminderDetails_remindTime.Size = new System.Drawing.Size(173, 13);
            this.reminderDetails_remindTime.TabIndex = 1;
            this.reminderDetails_remindTime.Text = "Reminds at: 11/11/11 at 11:11 PM";
            this.reminderDetails_remindTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reminderDetails_message
            // 
            this.reminderDetails_message.AutoEllipsis = true;
            this.reminderDetails_message.AutoSize = true;
            this.reminderDetails_message.Location = new System.Drawing.Point(3, 9);
            this.reminderDetails_message.MaximumSize = new System.Drawing.Size(265, 60);
            this.reminderDetails_message.Name = "reminderDetails_message";
            this.reminderDetails_message.Size = new System.Drawing.Size(264, 60);
            this.reminderDetails_message.TabIndex = 0;
            this.reminderDetails_message.Text = resources.GetString("reminderDetails_message.Text");
            this.reminderDetails_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationTrayIcon
            // 
            this.NotificationTrayIcon.ContextMenuStrip = this.NotificationTrayIconContextMenu;
            this.NotificationTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotificationTrayIcon.Icon")));
            this.NotificationTrayIcon.Text = "Forget me Not!";
            this.NotificationTrayIcon.Visible = true;
            this.NotificationTrayIcon.DoubleClick += new System.EventHandler(this.NotificationTrayIcon_Click);
            // 
            // NotificationTrayIconContextMenu
            // 
            this.NotificationTrayIconContextMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NotificationTrayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.NotificationTrayIconContextMenu.Name = "NotificationTrayIconContextMenu";
            this.NotificationTrayIconContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.NotificationTrayIconContextMenu.Size = new System.Drawing.Size(104, 26);
            this.NotificationTrayIconContextMenu.Text = "Forget me Not!";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.NotificationTrayIconContextMenu_Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(590, 379);
            this.Controls.Add(this.right_group);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.left_group);
            this.Name = "MainForm";
            this.Text = "Forget me Not!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.left_panel.ResumeLayout(false);
            this.createReminder_panel.ResumeLayout(false);
            this.createReminder_panel.PerformLayout();
            this.right_group.ResumeLayout(false);
            this.reminderDetails_panel.ResumeLayout(false);
            this.reminderDetails_panel.PerformLayout();
            this.NotificationTrayIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox createReminderGroup_reminderMessage;
		private System.Windows.Forms.Button createReminderGroup_remindIn30Minutes_btn;
		private System.Windows.Forms.Button createReminderGroup_remindInMorning_btn;
		private System.Windows.Forms.Button createReminderGroup_remindIn6Hours_btn;
		private System.Windows.Forms.Button createReminderGroup_remindIn1Hour_btn;
		private System.Windows.Forms.Label time_header;
		private System.Windows.Forms.DateTimePicker createReminderGroup_remindTime;
		private System.Windows.Forms.Button createReminderGroup_submitReminder_btn;
		private System.Windows.Forms.Label message_header;
        private System.Windows.Forms.GroupBox left_group;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.VScrollBar left_scroll;
        private System.Windows.Forms.Panel createReminder_panel;
        private System.Windows.Forms.GroupBox right_group;
        private System.Windows.Forms.Panel reminderDetails_panel;
        private System.Windows.Forms.Label reminderDetails_message;
        private System.Windows.Forms.Button reminderDetails_deleteBtn;
        private System.Windows.Forms.Button reminderDetails_copyBtn;
        private System.Windows.Forms.Button reminderDetails_editBtn;
        private System.Windows.Forms.Label reminderDetails_isSnoozeable;
        private System.Windows.Forms.Label reminderDetails_createdAtTime;
        private System.Windows.Forms.Label reminderDetails_remindTime;
        private System.Windows.Forms.Button reminderDetails_goBackBtn;
        private System.Windows.Forms.NotifyIcon NotificationTrayIcon;
        private System.Windows.Forms.ContextMenuStrip NotificationTrayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

