
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
			this.SuspendLayout();
			// 
			// createReminderBtn
			// 
			this.createReminderBtn.Location = new System.Drawing.Point(38, 50);
			this.createReminderBtn.Name = "createReminderBtn";
			this.createReminderBtn.Size = new System.Drawing.Size(103, 23);
			this.createReminderBtn.TabIndex = 0;
			this.createReminderBtn.Text = "Create Reminder";
			this.createReminderBtn.UseVisualStyleBackColor = true;
			this.createReminderBtn.Click += new System.EventHandler(this.createReminderBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.createReminderBtn);
			this.Name = "MainForm";
			this.Text = "Forget me Not!";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button createReminderBtn;
	}
}

