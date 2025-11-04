using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Data.Entity;
using static Restaurant.Data.Enums.Enums;   
using System.Data;

namespace Restaurant.WindowsForms
{
    public partial class CategoryView : SampleView
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Category> table;
        public CategoryView()
        {
            InitializeComponent();
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Category>();
        }
        public void GetData(IQueryable<Category> query)
        {
            var items = query.ToList();
            dgvCategory.Rows.Clear();
            int sno = 1;
            foreach (var item in items)
            {
                dgvCategory.Rows.Add(new object[]
                {
                    sno++,
                    item.Id,
                    item.Name,
                    item.Status,
                    item.Created,
                    item.Description,
                    item.Notes
                });
            }
        }
        private void CategoryView_Load(object sender, EventArgs e)
        {
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            var query = table.Where(c => c.Status != EntityStatus.Deleted && ((c.Name.Contains(searchText.Text)
            || c.Description.Contains(searchText.Text) || c.Notes.Contains(searchText.Text))));
            GetData(query);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            CategoryAdd categoryAdd = new CategoryAdd();
            categoryAdd.ShowDialog();
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName == "dgvEdit")
            {
                int id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["dgvId"].Value);
                CategoryAdd categoryAdd = new CategoryAdd(id);
                categoryAdd.ShowDialog();
            }
            else if (colName == "dgvDel")
            {
                int id = Convert.ToInt32(dgvCategory.Rows[e.RowIndex].Cells["dgvId"].Value);
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
            table = _applicationDbContext.Set<Category>();
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
    }
}
