using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Restaurant.Data;
using Restaurant.Data.Entity;
using Restaurant.Services;
using static Restaurant.Data.Entity.Tables;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.WindowsForms
{
    public partial class TableAdd : SampleAdd
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Tables> table;
        int? _tableId = null;
        public TableAdd(int? id = null)
        {
            InitializeComponent();
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Tables>();
            if (id != null)
            {
                if (id != null)
                {
                    headerLable.Text = "Edit Table";
                    _tableId = id;
                    loadData((int)id);
                }
            }
        }
        public void loadData(int id)
        {
            var tables = table.Find(id);
            if (tables != null)
            {
                numberText.Text = tables.Number;
                capacityText.Text = tables.Capacity.ToString();
                notesText.Text = tables.Notes;
                activeStatus.Checked = tables.Status == EntityStatus.Active;
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(numberText.Text) || string.IsNullOrEmpty(capacityText.Text))
            {
                MessageBox.Show("Please enter a table number and capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Tables tables;
                if (_tableId == null)
                {
                    tables = new Tables
                    {
                        Created = DateTime.Now,
                        CreatedBy = CurrentUserService.UserId.ToString()
                    };
                    table.Add(tables);
                }
                else
                {
                    tables = table.Find(_tableId);
                    if (tables == null)
                    {
                        MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    tables.LastModified = DateTime.Now;
                    tables.LastModifiedBy = CurrentUserService.UserId.ToString();
                }
                int.TryParse(capacityText.Text, out int capacity);
                tables.Number = numberText.Text;
                tables.Capacity = capacity;
                tables.Status = activeStatus.Checked ? EntityStatus.Active : EntityStatus.InActive;
                tables.Notes = notesText.Text;

                _applicationDbContext.SaveChanges();
                MessageBox.Show("Table saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the table: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void ClearFields()
        {
            numberText.Clear();
            capacityText.Clear();
            notesText.Clear();
            activeStatus.Checked = true;
        }
        private void clearBut_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        public override void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
