
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
			this.createReminderGroup_submitReminder_btn = new System.Windows.Forms.Button();
			this.createReminderGroup_remindTime = new System.Windows.Forms.DateTimePicker();
			this.createReminderGroup_remindInMorning_btn = new System.Windows.Forms.Button();
			this.createReminderGroup_remindIn6Hours_btn = new System.Windows.Forms.Button();
			this.createReminderGroup_remindIn1Hour_btn = new System.Windows.Forms.Button();
			this.time_header = new System.Windows.Forms.Label();
			this.createReminderGroup_remindIn30Minutes_btn = new System.Windows.Forms.Button();
			this.createReminderGroup_reminderMessage = new System.Windows.Forms.TextBox();
			this.message_header = new System.Windows.Forms.Label();
			this.createReminder_group.SuspendLayout();
			this.SuspendLayout();
			// 
			// createReminder_btn
			// 
			this.createReminder_btn.BackColor = System.Drawing.Color.Gray;
			this.createReminder_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.createReminder_btn.Location = new System.Drawing.Point(85, 50);
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
			this.createReminder_group.Location = new System.Drawing.Point(38, 79);
			this.createReminder_group.Name = "createReminder_group";
			this.createReminder_group.Size = new System.Drawing.Size(200, 203);
			this.createReminder_group.TabIndex = 1;
			this.createReminder_group.TabStop = false;
			this.createReminder_group.Text = "Reminder Details";
			this.createReminder_group.Visible = false;
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
			this.createReminderGroup_reminderMessage.BackColor = System.Drawing.Color.DarkGray;
			this.createReminderGroup_reminderMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.createReminderGroup_reminderMessage.Location = new System.Drawing.Point(6, 32);
			this.createReminderGroup_reminderMessage.Multiline = true;
			this.createReminderGroup_reminderMessage.Name = "createReminderGroup_reminderMessage";
			this.createReminderGroup_reminderMessage.Size = new System.Drawing.Size(188, 40);
			this.createReminderGroup_reminderMessage.TabIndex = 0;
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.createReminder_group);
			this.Controls.Add(this.createReminder_btn);
			this.Name = "MainForm";
			this.Text = "Forget me Not!";
			this.createReminder_group.ResumeLayout(false);
			this.createReminder_group.PerformLayout();
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
	}
}

