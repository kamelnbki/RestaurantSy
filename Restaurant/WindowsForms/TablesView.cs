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

            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = new Size(1024, 768);
     
        }

        private void TablesView_Load(object sender, EventArgs e)
        {
            GetData(table.Where(x => x.Status != EntityStatus.Deleted));

          
            SetupTableLayout();
        }

    
        private void SetupTableLayout()
        {
          
            if (dgvtable != null)
            {
                dgvtable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

           
                AdjustDataGridViewColumns();
            }

            if (searchText != null)
                searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            if (addBtn != null)
                addBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }

       
        private void AdjustDataGridViewColumns()
        {
            if (dgvtable.Columns.Count == 0) return;

            try
            {
               
                if (dgvtable.Columns.Count > 0)
                    dgvtable.Columns[0].Width = (int)(dgvtable.Width * 0.05);

                
                if (dgvtable.Columns.Count > 1)
                    dgvtable.Columns[1].Width = (int)(dgvtable.Width * 0.1);

               
                if (dgvtable.Columns.Count > 2)
                    dgvtable.Columns[2].Width = (int)(dgvtable.Width * 0.15);

           
                if (dgvtable.Columns.Count > 3)
                    dgvtable.Columns[3].Width = (int)(dgvtable.Width * 0.15);

               
                if (dgvtable.Columns.Count > 4)
                    dgvtable.Columns[4].Width = (int)(dgvtable.Width * 0.2);

              
                if (dgvtable.Columns.Count > 5)
                    dgvtable.Columns[5].Width = (int)(dgvtable.Width * 0.15);

               
                if (dgvtable.Columns.Count > 6)
                    dgvtable.Columns[6].Width = (int)(dgvtable.Width * 0.15);

                
                if (dgvtable.Columns.Count > 7)
                    dgvtable.Columns[7].Width = (int)(dgvtable.Width * 0.05);

                
                if (dgvtable.Columns.Count > 8)
                    dgvtable.Columns[8].Width = (int)(dgvtable.Width * 0.05);
            }
            catch (Exception ex)
            {
              
                Console.WriteLine("Error adjusting columns: " + ex.Message);
            }
        }

       
        private void TablesView_Resize(object sender, EventArgs e)
        {
            AdjustDataGridViewColumns();
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

            
            AdjustDataGridViewColumns();
        }

        public override void searchText_TextChanged(object sender, EventArgs e)
        {
            var query = table.Where(c => c.Status != EntityStatus.Deleted && (c.Number.ToString() == searchText.Text
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