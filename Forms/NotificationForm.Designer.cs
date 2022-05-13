namespace ForgetMeNot.Forms
{
    partial class NotificationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationForm));
            this.markAsDone_btn = new System.Windows.Forms.Button();
            this.snooze_btn = new System.Windows.Forms.Button();
            this.reminder_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // markAsDone_btn
            // 
            this.markAsDone_btn.BackColor = System.Drawing.Color.Gray;
            this.markAsDone_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markAsDone_btn.ForeColor = System.Drawing.Color.Black;
            this.markAsDone_btn.Location = new System.Drawing.Point(34, 124);
            this.markAsDone_btn.Name = "markAsDone_btn";
            this.markAsDone_btn.Size = new System.Drawing.Size(93, 40);
            this.markAsDone_btn.TabIndex = 2;
            this.markAsDone_btn.Text = "Mark as\r\nDone";
            this.markAsDone_btn.UseVisualStyleBackColor = false;
            this.markAsDone_btn.Click += new System.EventHandler(this.markAsDone_btn_Click);
            // 
            // snooze_btn
            // 
            this.snooze_btn.BackColor = System.Drawing.Color.Gray;
            this.snooze_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snooze_btn.ForeColor = System.Drawing.Color.Black;
            this.snooze_btn.Location = new System.Drawing.Point(162, 124);
            this.snooze_btn.Name = "snooze_btn";
            this.snooze_btn.Size = new System.Drawing.Size(134, 40);
            this.snooze_btn.TabIndex = 4;
            this.snooze_btn.Text = "Snooze\r\n(30 minutes)";
            this.snooze_btn.UseVisualStyleBackColor = false;
            this.snooze_btn.Click += new System.EventHandler(this.snooze_btn_Click);
            // 
            // reminder_message
            // 
            this.reminder_message.AutoEllipsis = true;
            this.reminder_message.AutoSize = true;
            this.reminder_message.Location = new System.Drawing.Point(31, 39);
            this.reminder_message.MaximumSize = new System.Drawing.Size(265, 60);
            this.reminder_message.Name = "reminder_message";
            this.reminder_message.Size = new System.Drawing.Size(264, 60);
            this.reminder_message.TabIndex = 5;
            this.reminder_message.Text = resources.GetString("reminder_message.Text");
            this.reminder_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(327, 193);
            this.Controls.Add(this.reminder_message);
            this.Controls.Add(this.snooze_btn);
            this.Controls.Add(this.markAsDone_btn);
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder!";
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button markAsDone_btn;
        private System.Windows.Forms.Button snooze_btn;
        private System.Windows.Forms.Label reminder_message;
    }
}