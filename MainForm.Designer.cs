
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
            this.createReminder_btn = new System.Windows.Forms.Button();
            this.createReminder_group = new System.Windows.Forms.GroupBox();
            this.message_header = new System.Windows.Forms.Label();
            this.createReminderGroup_submitReminder_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_remindTime = new System.Windows.Forms.DateTimePicker();
            this.createReminderGroup_remindInMorning_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_remindIn6Hours_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_remindIn1Hour_btn = new System.Windows.Forms.Button();
            this.time_header = new System.Windows.Forms.Label();
            this.createReminderGroup_remindIn30Minutes_btn = new System.Windows.Forms.Button();
            this.createReminderGroup_reminderMessage = new System.Windows.Forms.TextBox();
            this.remindersList = new System.Windows.Forms.ListBox();
            this.reminders_group = new System.Windows.Forms.GroupBox();
            this.reminderBtn_ = new System.Windows.Forms.Button();
            this.reminder1_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.createReminder_group.SuspendLayout();
            this.reminders_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // createReminder_btn
            // 
            this.createReminder_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createReminder_btn.Location = new System.Drawing.Point(519, 50);
            this.createReminder_btn.Name = "createReminder_btn";
            this.createReminder_btn.Size = new System.Drawing.Size(103, 23);
            this.createReminder_btn.TabIndex = 0;
            this.createReminder_btn.Text = "Create Reminder";
            this.createReminder_btn.UseVisualStyleBackColor = false;
            this.createReminder_btn.Click += new System.EventHandler(this.createReminderBtn_Click);
            // 
            // createReminder_group
            // 
            this.createReminder_group.Controls.Add(this.message_header);
            this.createReminder_group.Controls.Add(this.createReminderGroup_submitReminder_btn);
            this.createReminder_group.Controls.Add(this.createReminderGroup_remindTime);
            this.createReminder_group.Controls.Add(this.createReminderGroup_remindInMorning_btn);
            this.createReminder_group.Controls.Add(this.createReminderGroup_remindIn6Hours_btn);
            this.createReminder_group.Controls.Add(this.createReminderGroup_remindIn1Hour_btn);
            this.createReminder_group.Controls.Add(this.time_header);
            this.createReminder_group.Controls.Add(this.createReminderGroup_remindIn30Minutes_btn);
            this.createReminder_group.Controls.Add(this.createReminderGroup_reminderMessage);
            this.createReminder_group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createReminder_group.ForeColor = System.Drawing.Color.Silver;
            this.createReminder_group.Location = new System.Drawing.Point(484, 95);
            this.createReminder_group.Name = "createReminder_group";
            this.createReminder_group.Size = new System.Drawing.Size(200, 203);
            this.createReminder_group.TabIndex = 1;
            this.createReminder_group.TabStop = false;
            this.createReminder_group.Text = "Reminder Details";
            this.createReminder_group.Visible = false;
            // 
            // message_header
            // 
            this.message_header.AutoSize = true;
            this.message_header.ForeColor = System.Drawing.Color.Black;
            this.message_header.Location = new System.Drawing.Point(57, 16);
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
            this.createReminderGroup_submitReminder_btn.Location = new System.Drawing.Point(60, 173);
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
            this.createReminderGroup_remindTime.Location = new System.Drawing.Point(6, 149);
            this.createReminderGroup_remindTime.MinDate = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            this.createReminderGroup_remindTime.Name = "createReminderGroup_remindTime";
            this.createReminderGroup_remindTime.Size = new System.Drawing.Size(188, 20);
            this.createReminderGroup_remindTime.TabIndex = 3;
            this.createReminderGroup_remindTime.Value = new System.DateTime(2022, 1, 11, 0, 0, 0, 0);
            // 
            // createReminderGroup_remindInMorning_btn
            // 
            this.createReminderGroup_remindInMorning_btn.BackColor = System.Drawing.Color.Gray;
            this.createReminderGroup_remindInMorning_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReminderGroup_remindInMorning_btn.ForeColor = System.Drawing.Color.Black;
            this.createReminderGroup_remindInMorning_btn.Location = new System.Drawing.Point(106, 120);
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
            this.createReminderGroup_remindIn6Hours_btn.Location = new System.Drawing.Point(15, 120);
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
            this.createReminderGroup_remindIn1Hour_btn.Location = new System.Drawing.Point(106, 91);
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
            this.time_header.Location = new System.Drawing.Point(84, 75);
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
            this.createReminderGroup_remindIn30Minutes_btn.Location = new System.Drawing.Point(15, 91);
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
            this.createReminderGroup_reminderMessage.Location = new System.Drawing.Point(6, 32);
            this.createReminderGroup_reminderMessage.Multiline = true;
            this.createReminderGroup_reminderMessage.Name = "createReminderGroup_reminderMessage";
            this.createReminderGroup_reminderMessage.Size = new System.Drawing.Size(188, 40);
            this.createReminderGroup_reminderMessage.TabIndex = 0;
            // 
            // remindersList
            // 
            this.remindersList.FormattingEnabled = true;
            this.remindersList.Location = new System.Drawing.Point(519, 325);
            this.remindersList.Name = "remindersList";
            this.remindersList.Size = new System.Drawing.Size(120, 95);
            this.remindersList.TabIndex = 2;
            // 
            // reminders_group
            // 
            this.reminders_group.Controls.Add(this.textBox1);
            this.reminders_group.Controls.Add(this.label1);
            this.reminders_group.Controls.Add(this.reminder1_text);
            this.reminders_group.Controls.Add(this.reminderBtn_);
            this.reminders_group.Location = new System.Drawing.Point(24, 24);
            this.reminders_group.Name = "reminders_group";
            this.reminders_group.Size = new System.Drawing.Size(280, 362);
            this.reminders_group.TabIndex = 3;
            this.reminders_group.TabStop = false;
            this.reminders_group.Text = "Reminders";
            // 
            // reminderBtn_
            // 
            this.reminderBtn_.BackColor = System.Drawing.Color.Gray;
            this.reminderBtn_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderBtn_.ForeColor = System.Drawing.Color.Black;
            this.reminderBtn_.Location = new System.Drawing.Point(6, 19);
            this.reminderBtn_.Name = "reminderBtn_";
            this.reminderBtn_.Size = new System.Drawing.Size(268, 52);
            this.reminderBtn_.TabIndex = 7;
            this.reminderBtn_.UseVisualStyleBackColor = false;
            // 
            // reminder1_text
            // 
            this.reminder1_text.BackColor = System.Drawing.Color.Gray;
            this.reminder1_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reminder1_text.Cursor = System.Windows.Forms.Cursors.Default;
            this.reminder1_text.Enabled = false;
            this.reminder1_text.Location = new System.Drawing.Point(10, 22);
            this.reminder1_text.Multiline = true;
            this.reminder1_text.Name = "reminder1_text";
            this.reminder1_text.ReadOnly = true;
            this.reminder1_text.Size = new System.Drawing.Size(260, 26);
            this.reminder1_text.TabIndex = 9;
            this.reminder1_text.Text = "Take out the trash and recycling, and do vacuuming. REEEEEEEEEEEEEEEEEEEEEEEEEEEE" +
    "EEEEEEEEEEEEEEEEEEEEEEEEEEEEEE";
            this.reminder1_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 3);
            this.label1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(260, 13);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "Reminds... tomorrow at 2 pm";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(734, 442);
            this.Controls.Add(this.reminders_group);
            this.Controls.Add(this.remindersList);
            this.Controls.Add(this.createReminder_group);
            this.Controls.Add(this.createReminder_btn);
            this.Name = "MainForm";
            this.Text = "Forget me Not!";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.createReminder_group.ResumeLayout(false);
            this.createReminder_group.PerformLayout();
            this.reminders_group.ResumeLayout(false);
            this.reminders_group.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button createReminder_btn;
		private System.Windows.Forms.GroupBox createReminder_group;
		private System.Windows.Forms.TextBox createReminderGroup_reminderMessage;
		private System.Windows.Forms.Button createReminderGroup_remindIn30Minutes_btn;
		private System.Windows.Forms.Button createReminderGroup_remindInMorning_btn;
		private System.Windows.Forms.Button createReminderGroup_remindIn6Hours_btn;
		private System.Windows.Forms.Button createReminderGroup_remindIn1Hour_btn;
		private System.Windows.Forms.Label time_header;
		private System.Windows.Forms.DateTimePicker createReminderGroup_remindTime;
		private System.Windows.Forms.Button createReminderGroup_submitReminder_btn;
		private System.Windows.Forms.Label message_header;
        private System.Windows.Forms.ListBox remindersList;
        private System.Windows.Forms.GroupBox reminders_group;
        private System.Windows.Forms.Button reminderBtn_;
        private System.Windows.Forms.TextBox reminder1_text;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

