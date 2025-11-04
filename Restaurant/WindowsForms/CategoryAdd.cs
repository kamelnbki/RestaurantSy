using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Data.Entity;
using Restaurant.Services;
using static Restaurant.Data.Enums.Enums;

namespace Restaurant.WindowsForms
{
    public partial class CategoryAdd : SampleAdd
    {
        ApplicationDbContext _applicationDbContext;
        DbSet<Category> table;
        private int? _categoryId = null;
        public CategoryAdd(int? id = null)
        {
            InitializeComponent();
            _applicationDbContext = new ApplicationDbContext();
            table = _applicationDbContext.Set<Category>();
            if (id != null)
            {
                headerLable.Text = "Edit Category";
                _categoryId = id;
                loadData((int)id);
            }
        }
        public void loadData(int id)
        {
            var category = table.Find(id);
            if (category != null)
            {
                nameText.Text = category.Name;
                descriptionText.Text = category.Description;
                notesText.Text = category.Notes;
                activeStatus.Checked = category.Status == EntityStatus.Active;
            }
        }
        public override void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameText.Text))
            {
                MessageBox.Show("Please enter a category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Category category;
                if (_categoryId == null)
                {
                    category = new Category
                    {
                        Created = DateTime.Now,
                        CreatedBy = CurrentUserService.UserId.ToString()
                    };
                    table.Add(category);
                }
                else
                {
                    category = table.Find(_categoryId);
                    if (category == null)
                    {
                        MessageBox.Show("Category not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    category.LastModified = DateTime.Now;
                    category.LastModifiedBy = CurrentUserService.UserId.ToString();
                }

                category.Name = nameText.Text;
                category.Description = descriptionText.Text;
                category.Status = activeStatus.Checked ? EntityStatus.Active : EntityStatus.InActive;
                category.Notes = notesText.Text;

                _applicationDbContext.SaveChanges();
                MessageBox.Show("Category saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the category: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        public void ClearFields()
        {
            nameText.Clear();
            descriptionText.Clear();
            notesText.Clear();
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
