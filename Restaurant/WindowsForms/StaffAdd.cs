using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Data.Entity;
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
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.WindowsForms
{
    public partial class StaffAdd : SampleAdd
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Staff> table;
        private int? _staffId = null;
        public StaffAdd(int? id = null)
        {
            InitializeComponent();
            roleComBox.DataSource = Enum.GetValues(typeof(EntityRoles));
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Staff>();
            if (id != null)
            {
                headerLable.Text = "Edit Staff";
                _staffId = id;
                loadData((int)id);
            }
        }
        public void loadData(int id)
        {
            var staff = table.Find(id);
            if (staff != null)
            {
                nameText.Text = staff.Name;
                phoneText.Text = staff.Phone;
                activeStatus.Checked = staff.Status == EntityStatus.Active;
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameText.Text))
            {
                MessageBox.Show("Please enter a staff name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Staff staff;
                if (_staffId == null)
                {
                    staff = new Staff
                    {
                        Created = DateTime.Now,
                        CreatedBy = CurrentUserService.UserId.ToString()
                    };
                    table.Add(staff);
                }
                else
                {
                    staff = table.Find(_staffId);
                    if (staff == null)
                    {
                        MessageBox.Show("Staff not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    staff.LastModified = DateTime.Now;
                    staff.LastModifiedBy = CurrentUserService.UserId.ToString();
                }

                staff.Name = nameText.Text;
                staff.Phone = phoneText.Text;
                staff.Status = activeStatus.Checked ? EntityStatus.Active : EntityStatus.InActive;

                _applicationDbContext.SaveChanges();
                MessageBox.Show("Staff saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the staff : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void ClearFields()
        {
            nameText.Clear();
            phoneText.Clear();
            activeStatus.Checked = true;
        }
        public override void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
