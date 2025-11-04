using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Data.Entity;
using Restaurant.Interface;
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

namespace Restaurant.WindowsForms;

internal partial class Login : Form
{
    CurrentUserService _currentUser; 
    ApplicationDbContext _applicationDbContext;
    DbSet<User> table;
    public Login()
    {
        InitializeComponent();
        _applicationDbContext = new ApplicationDbContext();
        table = _applicationDbContext.Set<User>();
    }
    private void loginBtn_Click(object sender, EventArgs e)
    {
        string userName = userNameText.Text?.Trim();
        string password = passwordText.Text?.Trim();
        if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter both username and password.", "Validation Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        var user = table.Where(u => u.UserName == userName && u.Password == password)
               .FirstOrDefault();
        
        if (user is not null)
        {
            CurrentUserService.UserId = user.Id;
            CurrentUserService.Name = user.Name;
            CurrentUserService.Role = user.Role;
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid username or password.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void exitBtn_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}

