using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Data.Entity;
using System.Data;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.WindowsForms
{
    public partial class TablesView : SampleView
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Tables> table;
        public TablesView()
        {
            InitializeComponent();
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Tables>();
        }

        private void TablesView_Load(object sender, EventArgs e)
        {
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
        public void GetData(IQueryable<Tables> query)
        {
            var items = query.ToList();
            dgvtable.Rows.Clear();
            int sno = 1;
            foreach (var item in items)
            {
                dgvtable.Rows.Add(new object[]
                {
                    sno++,
                    item.Id,
                    item.Number,
                    item.Status,
                    item.Created,
                    item.Capacity,
                    item.Notes
                });
            }
        }
        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            var query = table.Where(c => c.Status != EntityStatus.Deleted &&( c.Number.ToString() == searchText.Text
            || c.Capacity.ToString() == searchText.Text || c.Notes.Contains(searchText.Text)));
            GetData(query);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            TableAdd tableAdd = new TableAdd();
            tableAdd.ShowDialog();
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
        private void dgvtable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvtable.Columns[e.ColumnIndex].Name;
            if (colName == "dgvEdit")
            {
                int id = Convert.ToInt32(dgvtable.Rows[e.RowIndex].Cells["dgvId"].Value);
                TableAdd tableAdd = new TableAdd(id);
                tableAdd.ShowDialog();
            }
            else if (colName == "dgvDel")
            {
                int id = Convert.ToInt32(dgvtable.Rows[e.RowIndex].Cells["dgvId"].Value);
                var item = table.Find(id);
                if (item != null)
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        item.Status = EntityStatus.Deleted;
                        _applicationDbContext.SaveChanges();
                    }
                }
            }
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Tables>();
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }

    }
}
