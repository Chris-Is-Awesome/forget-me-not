using System;
using System.Drawing;
using System.Windows.Forms;

namespace ForgetMeNot
{
    static class ComponentHelper
    {
        public struct ButtonData
        {
            public Color BackgroundColor { get; set; }
            public Color TextColor { get; set; }
            public FlatStyle FlatStyle { get; set; }
            public string Name { get; set; }
            public string Text { get; set; }
            public ContentAlignment TextAlign { get; set; }
            public Point Location { get; set; }
            public Size Size { get; set; }
            public EventHandler Callback { get; set; }
        }

        public static Button CreateButton(ButtonData data)
        {
            Button button = new Button();
            button.BackColor = data.BackgroundColor;
            button.ForeColor = data.TextColor;
            button.FlatStyle = data.FlatStyle;
            button.Name = data.Name;
            button.Text = data.Text;
            button.TextAlign = data.TextAlign;
            button.Location = data.Location;
            button.Size = data.Size;
            button.Click += data.Callback;
            return button;
        }
    }
}
