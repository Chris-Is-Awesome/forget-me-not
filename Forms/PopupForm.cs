using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ForgetMeNot
{
	public partial class PopupForm : Form
	{
		public delegate void ButtonClick(object sender, EventArgs e);
		public event ButtonClick OnButton1Click;
		public event ButtonClick OnButton2Click;

		public PopupForm(string message, string button1Text, string button2Text = "")
		{
			InitializeComponent();
			this.message.Text = message;
			button1.Location = new Point
			{
				X = button1.Location.X,
				Y = this.message.Height + 25
			};
			button1.Text = button1Text;
			
			if (!string.IsNullOrEmpty(button2Text))
			{
				button2.Location = new Point
				{
					X = button1.Location.X,
					Y = button1.Location.Y + 29
				};
				button2.Text = button2Text;
				button2.Visible = true;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OnButton1Click?.Invoke(sender, e);
			Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OnButton2Click?.Invoke(sender, e);
			Close();
		}
	}
}
