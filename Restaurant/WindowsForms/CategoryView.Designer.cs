namespace Restaurant.WindowsForms
{
    partial class CategoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dgvCategory = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvSno = new DataGridViewTextBoxColumn();
            dgvId = new DataGridViewTextBoxColumn();
            dgvName = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            dgvDate = new DataGridViewTextBoxColumn();
            dgvDescription = new DataGridViewTextBoxColumn();
            dgvNotes = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // HeaderLable
            // 
            HeaderLable.Location = new Point(32, 25);
            HeaderLable.Size = new Size(152, 32);
            HeaderLable.Text = "Category List";
            // 
            // searchText
            // 
            searchText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.Location = new Point(1099, 81);
            searchText.ShadowDecoration.CustomizableEdges = customizableEdges1;
            searchText.Size = new Size(218, 53);
            // 
            // addBtn
            // 
            addBtn.CheckedState.ImageSize = new Size(64, 64);
            addBtn.DialogResult = DialogResult.None;
            addBtn.HoverState.ImageSize = new Size(64, 64);
            addBtn.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            addBtn.Location = new Point(45, 72);
            addBtn.PressedState.ImageSize = new Size(64, 64);
            addBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // searchLable
            // 
            searchLable.Location = new Point(1099, 48);
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Silver;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategory.ColumnHeadersHeight = 60;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { dgvSno, dgvId, dgvName, dgvStatus, dgvDate, dgvDescription, dgvNotes, dgvEdit, dgvDel });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCategory.GridColor = Color.White;
            dgvCategory.Location = new Point(17, 188);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCategory.RowHeadersVisible = false;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCategory.RowTemplate.Height = 70;
            dgvCategory.Size = new Size(1353, 606);
            dgvCategory.TabIndex = 6;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCategory.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCategory.ThemeStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.GridColor = Color.White;
            dgvCategory.ThemeStyle.HeaderStyle.BackColor = Color.Silver;
            dgvCategory.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCategory.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCategory.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            dgvCategory.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvCategory.ThemeStyle.HeaderStyle.Height = 60;
            dgvCategory.ThemeStyle.ReadOnly = true;
            dgvCategory.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCategory.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCategory.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvCategory.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvCategory.ThemeStyle.RowsStyle.Height = 70;
            dgvCategory.ThemeStyle.RowsStyle.SelectionBackColor = Color.White;
            dgvCategory.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvCategory.CellContentClick += dgvCategory_CellClick;
            // 
            // dgvSno
            // 
            dgvSno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvSno.FillWeight = 70F;
            dgvSno.HeaderText = "Sr#";
            dgvSno.MinimumWidth = 70;
            dgvSno.Name = "dgvSno";
            dgvSno.ReadOnly = true;
            dgvSno.Width = 70;
            // 
            // dgvId
            // 
            dgvId.HeaderText = "Id";
            dgvId.MinimumWidth = 6;
            dgvId.Name = "dgvId";
            dgvId.ReadOnly = true;
            dgvId.Visible = false;
            // 
            // dgvName
            // 
            dgvName.HeaderText = "Name";
            dgvName.MinimumWidth = 6;
            dgvName.Name = "dgvName";
            dgvName.ReadOnly = true;
            // 
            // dgvStatus
            // 
            dgvStatus.HeaderText = "Status";
            dgvStatus.MinimumWidth = 6;
            dgvStatus.Name = "dgvStatus";
            dgvStatus.ReadOnly = true;
            // 
            // dgvDate
            // 
            dgvDate.HeaderText = "Date";
            dgvDate.MinimumWidth = 6;
            dgvDate.Name = "dgvDate";
            dgvDate.ReadOnly = true;
            // 
            // dgvDescription
            // 
            dgvDescription.HeaderText = "Description";
            dgvDescription.MinimumWidth = 6;
            dgvDescription.Name = "dgvDescription";
            dgvDescription.ReadOnly = true;
            // 
            // dgvNotes
            // 
            dgvNotes.HeaderText = "Notes";
            dgvNotes.MinimumWidth = 6;
            dgvNotes.Name = "dgvNotes";
            dgvNotes.ReadOnly = true;
            // 
            // dgvEdit
            // 
            dgvEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvEdit.FillWeight = 40F;
            dgvEdit.HeaderText = "";
            dgvEdit.Image = Properties.Resources.pen_circle;
            dgvEdit.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvEdit.MinimumWidth = 40;
            dgvEdit.Name = "dgvEdit";
            dgvEdit.ReadOnly = true;
            dgvEdit.Width = 40;
            // 
            // dgvDel
            // 
            dgvDel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvDel.FillWeight = 40F;
            dgvDel.HeaderText = "";
            dgvDel.Image = Properties.Resources.trash;
            dgvDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgvDel.MinimumWidth = 40;
            dgvDel.Name = "dgvDel";
            dgvDel.ReadOnly = true;
            dgvDel.Width = 40;
            // 
            // CategoryView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 806);
            Controls.Add(dgvCategory);
            Name = "CategoryView";
            Text = "CategoryView";
            Load += CategoryView_Load;
            Controls.SetChildIndex(searchLable, 0);
            Controls.SetChildIndex(searchText, 0);
            Controls.SetChildIndex(addBtn, 0);
            Controls.SetChildIndex(HeaderLable, 0);
            Controls.SetChildIndex(dgvCategory, 0);
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvCategory;
        private DataGridViewTextBoxColumn dgvSno;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvName;
        private DataGridViewTextBoxColumn dgvDescription;
        private DataGridViewTextBoxColumn dgvNotes;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvDate;
    }
}