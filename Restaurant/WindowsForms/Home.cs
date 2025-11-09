using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;  
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //RoundButton(Menu_btn, 30);
            //RoundButton(button1, 10);

            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1024, 768);

            if (Menu_btn != null)
                Menu_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            if (button1 != null)
                button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;

        }

        private void RoundButton(Button btn, int radius)
        {
            Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            btn.Region = new Region(path);
        }

        private void Menu_btn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}