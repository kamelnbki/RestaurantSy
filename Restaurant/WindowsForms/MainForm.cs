using Restaurant.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.WindowsForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void AddControlToPanel(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AddControlToPanel(new Home());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            UserLabel.Text = CurrentUserService.Name;
            AddControlToPanel(new Home());
        }
        private void CategoriesBtn_Click(object sender, EventArgs e)
        {
            AddControlToPanel(new CategoryView());
        }
        private void singoutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void TablesBtn_Click(object sender, EventArgs e)
        {
            AddControlToPanel(new TablesView());
        }

        private void staffBtn_Click(object sender, EventArgs e)
        {
            AddControlToPanel(new StaffView());
        }
    }
}
