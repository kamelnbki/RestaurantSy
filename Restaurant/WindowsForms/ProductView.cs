using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Data.Entity;
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
    public partial class ProductView : SampleView
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Products> table;
        public ProductView()
        {
            InitializeComponent();
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Products>();
        }
        public void GetData(IQueryable<Products> query)
        {
            var items = query.Include(x => x.Category).ToList();
            dgvProduct.Rows.Clear();
            int sno = 1;
            foreach (var item in items)
            {
                dgvProduct.Rows.Add(new object[]
                {
                    sno++,
                    item.Id,
                    item.Name,
                    item.Status,
                    item.Created,
                    item.Price,
                    item.Category.Name,
                });
            }
        }
        private void ProductView_Load(object sender, EventArgs e)
        {
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            var query = table.Where(c => c.Status != EntityStatus.Deleted && ((c.Name.Contains(searchText.Text)
            || c.Price.ToString().Contains(searchText.Text) || c.Category.Name.Contains(searchText.Text))));
            GetData(query);
        }
        public override void addBtn_Click(object sender, EventArgs e)
        {
            ProductAdd categoryAdd = new ProductAdd();
            categoryAdd.ShowDialog();
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            if (colName == "dgvEdit")
            {
                int id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvId"].Value);
                ProductAdd productAdd = new ProductAdd(id);
                productAdd.ShowDialog();
            }
            else if (colName == "dgvDel")
            {
                int id = Convert.ToInt32(dgvProduct.Rows[e.RowIndex].Cells["dgvId"].Value);
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
            table = _applicationDbContext.Set<Products>();
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));
        }
    }
}
