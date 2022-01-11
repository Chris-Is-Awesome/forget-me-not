
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
			this.createReminderBtn = new System.Windows.Forms.Button();
			this.createReminder_group = new System.Windows.Forms.GroupBox();
			this.createReminder_dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.remindInMorning_btn = new System.Windows.Forms.Button();
			this.remindIn6Hours_btn = new System.Windows.Forms.Button();
			this.remindIn1Hour_btn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.remindIn30Minutes_btn = new System.Windows.Forms.Button();
			this.createReminder_text = new System.Windows.Forms.TextBox();
			this.createReminder_group.SuspendLayout();
			this.SuspendLayout();
			// 
			// createReminderBtn
			// 
			this.createReminderBtn.Location = new System.Drawing.Point(85, 50);
			this.createReminderBtn.Name = "createReminderBtn";
			this.createReminderBtn.Size = new System.Drawing.Size(103, 23);
			this.createReminderBtn.TabIndex = 0;
			this.createReminderBtn.Text = "Create Reminder";
			this.createReminderBtn.UseVisualStyleBackColor = true;
			this.createReminderBtn.Click += new System.EventHandler(this.createReminderBtn_Click);
			// 
			// createReminder_group
			// 
			this.createReminder_group.Controls.Add(this.createReminder_dateTimePicker);
			this.createReminder_group.Controls.Add(this.remindInMorning_btn);
			this.createReminder_group.Controls.Add(this.remindIn6Hours_btn);
			this.createReminder_group.Controls.Add(this.remindIn1Hour_btn);
			this.createReminder_group.Controls.Add(this.label1);
			this.createReminder_group.Controls.Add(this.remindIn30Minutes_btn);
			this.createReminder_group.Controls.Add(this.createReminder_text);
			this.createReminder_group.Location = new System.Drawing.Point(38, 79);
			this.createReminder_group.Name = "createReminder_group";
			this.createReminder_group.Size = new System.Drawing.Size(200, 165);
			this.createReminder_group.TabIndex = 1;
			this.createReminder_group.TabStop = false;
			this.createReminder_group.Text = "Reminder Details";
			this.createReminder_group.Visible = false;
			// 
			// createReminder_dateTimePicker
			// 
			this.createReminder_dateTimePicker.CustomFormat = "MM/dd/yy @ hh:mm tt";
			this.createReminder_dateTimePicker.Location = new System.Drawing.Point(6, 136);
			this.createReminder_dateTimePicker.Name = "createReminder_dateTimePicker";
			this.createReminder_dateTimePicker.Size = new System.Drawing.Size(188, 20);
			this.createReminder_dateTimePicker.TabIndex = 3;
			// 
			// remindInMorning_btn
			// 
			this.remindInMorning_btn.Location = new System.Drawing.Point(106, 107);
			this.remindInMorning_btn.Name = "remindInMorning_btn";
			this.remindInMorning_btn.Size = new System.Drawing.Size(75, 23);
			this.remindInMorning_btn.TabIndex = 5;
			this.remindInMorning_btn.Text = "Morning";
			this.remindInMorning_btn.UseVisualStyleBackColor = true;
			this.remindInMorning_btn.Click += new System.EventHandler(this.remindInMorning_btn_Click);
			// 
			// remindIn6Hours_btn
			// 
			this.remindIn6Hours_btn.Location = new System.Drawing.Point(15, 107);
			this.remindIn6Hours_btn.Name = "remindIn6Hours_btn";
			this.remindIn6Hours_btn.Size = new System.Drawing.Size(75, 23);
			this.remindIn6Hours_btn.TabIndex = 4;
			this.remindIn6Hours_btn.Text = "6 hours";
			this.remindIn6Hours_btn.UseVisualStyleBackColor = true;
			this.remindIn6Hours_btn.Click += new System.EventHandler(this.remindIn6Hours_btn_Click);
			// 
			// remindIn1Hour_btn
			// 
			this.remindIn1Hour_btn.Location = new System.Drawing.Point(106, 78);
			this.remindIn1Hour_btn.Name = "remindIn1Hour_btn";
			this.remindIn1Hour_btn.Size = new System.Drawing.Size(75, 23);
			this.remindIn1Hour_btn.TabIndex = 3;
			this.remindIn1Hour_btn.Text = "1 hour";
			this.remindIn1Hour_btn.UseVisualStyleBackColor = true;
			this.remindIn1Hour_btn.Click += new System.EventHandler(this.remindIn1Hour_btn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "When to remind me...";
			// 
			// remindIn30Minutes_btn
			// 
			this.remindIn30Minutes_btn.Location = new System.Drawing.Point(15, 78);
			this.remindIn30Minutes_btn.Name = "remindIn30Minutes_btn";
			this.remindIn30Minutes_btn.Size = new System.Drawing.Size(75, 23);
			this.remindIn30Minutes_btn.TabIndex = 1;
			this.remindIn30Minutes_btn.Text = "30 minutes";
			this.remindIn30Minutes_btn.UseVisualStyleBackColor = true;
			this.remindIn30Minutes_btn.Click += new System.EventHandler(this.remindIn30Minutes_btn_Click);
			// 
			// createReminder_text
			// 
			this.createReminder_text.AcceptsReturn = true;
			this.createReminder_text.Location = new System.Drawing.Point(6, 19);
			this.createReminder_text.Multiline = true;
			this.createReminder_text.Name = "createReminder_text";
			this.createReminder_text.Size = new System.Drawing.Size(188, 40);
			this.createReminder_text.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.createReminder_group);
			this.Controls.Add(this.createReminderBtn);
			this.Name = "MainForm";
			this.Text = "Forget me Not!";
			this.createReminder_group.ResumeLayout(false);
			this.createReminder_group.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button createReminderBtn;
		private System.Windows.Forms.GroupBox createReminder_group;
		private System.Windows.Forms.TextBox createReminder_text;
		private System.Windows.Forms.Button remindIn30Minutes_btn;
		private System.Windows.Forms.Button remindInMorning_btn;
		private System.Windows.Forms.Button remindIn6Hours_btn;
		private System.Windows.Forms.Button remindIn1Hour_btn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker createReminder_dateTimePicker;
	}
}

