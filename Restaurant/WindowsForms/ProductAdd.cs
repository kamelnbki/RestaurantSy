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
    public partial class ProductAdd : SampleAdd
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Products> table;
        private int? _productId = null;
        public ProductAdd(int? id = null)
        {
            InitializeComponent();
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Products>();
            categoryComBox.DataSource = _applicationDbContext.Set<Category>().ToList();
            categoryComBox.DisplayMember = "Name";
            categoryComBox.ValueMember = "Id";
            if (id != null)
            {
                headerLable.Text = "Edit Product";
                _productId = id;
                loadData((int)id);
            }

        }
        public void loadData(int id)
        {
            var product = table.Find(id);
            if (product != null)
            {
                nameText.Text = product.Name;
                priceText.Text = product.Price.ToString();
                categoryComBox.SelectedValue = product.CategoryId;
                activeStatus.Checked = product.Status == EntityStatus.Active;
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameText.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Products product;
                if (_productId == null)
                {
                    product = new Products
                    {
                        Created = DateTime.Now,
                        CreatedBy = CurrentUserService.UserId.ToString()
                    };
                    table.Add(product);
                }
                else
                {
                    product = table.Find(_productId);
                    if (product == null)
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    product.LastModified = DateTime.Now;
                    product.LastModifiedBy = CurrentUserService.UserId.ToString();
                }

                product.Name = nameText.Text;
                product.Price = Convert.ToDouble(priceText.Text);
                product.Status = activeStatus.Checked ? EntityStatus.Active : EntityStatus.InActive;
                product.CategoryId = (int)categoryComBox.SelectedValue;

                _applicationDbContext.SaveChanges();
                MessageBox.Show("Product saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void ClearFields()
        {
            nameText.Clear();
            priceText.Clear();
            categoryComBox.SelectedValue = 1;
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
