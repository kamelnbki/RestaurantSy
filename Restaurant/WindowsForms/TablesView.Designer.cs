namespace Restaurant.WindowsForms
{
    partial class TablesView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvtable = new Guna.UI2.WinForms.Guna2DataGridView();
            dgvSno = new DataGridViewTextBoxColumn();
            dgvId = new DataGridViewTextBoxColumn();
            dgvNumber = new DataGridViewTextBoxColumn();
            dgvStatus = new DataGridViewTextBoxColumn();
            dgvDate = new DataGridViewTextBoxColumn();
            dgvCapacity = new DataGridViewTextBoxColumn();
            dgvNotes = new DataGridViewTextBoxColumn();
            dgvEdit = new DataGridViewImageColumn();
            dgvDel = new DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)dgvtable).BeginInit();
            SuspendLayout();
            // 
            // HeaderLable
            // 
            HeaderLable.Location = new Point(34, 25);
            HeaderLable.Size = new Size(111, 32);
            HeaderLable.Text = "Table List";
            // 
            // searchText
            // 
            searchText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.Location = new Point(1077, 81);
            searchText.ShadowDecoration.CustomizableEdges = customizableEdges3;
            searchText.Size = new Size(243, 53);
            // 
            // addBtn
            // 
            addBtn.CheckedState.ImageSize = new Size(64, 64);
            addBtn.DialogResult = DialogResult.None;
            addBtn.HoverState.ImageSize = new Size(64, 64);
            addBtn.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            addBtn.Location = new Point(47, 72);
            addBtn.PressedState.ImageSize = new Size(64, 64);
            addBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // searchLable
            // 
            searchLable.Location = new Point(1077, 48);
            // 
            // dgvtable
            // 
            dgvtable.AllowUserToAddRows = false;
            dgvtable.AllowUserToDeleteRows = false;
            dgvtable.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dgvtable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvtable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.Silver;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvtable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvtable.ColumnHeadersHeight = 60;
            dgvtable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvtable.Columns.AddRange(new DataGridViewColumn[] { dgvSno, dgvId, dgvNumber, dgvStatus, dgvDate, dgvCapacity, dgvNotes, dgvEdit, dgvDel });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle8.SelectionBackColor = Color.White;
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvtable.DefaultCellStyle = dataGridViewCellStyle8;
            dgvtable.GridColor = Color.White;
            dgvtable.Location = new Point(17, 188);
            dgvtable.Name = "dgvtable";
            dgvtable.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvtable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvtable.RowHeadersVisible = false;
            dgvtable.RowHeadersWidth = 51;
            dgvtable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.White;
            dataGridViewCellStyle10.SelectionForeColor = Color.Black;
            dgvtable.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvtable.RowTemplate.Height = 70;
            dgvtable.Size = new Size(1353, 435);
            dgvtable.TabIndex = 7;
            dgvtable.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvtable.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvtable.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvtable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvtable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvtable.ThemeStyle.BackColor = Color.White;
            dgvtable.ThemeStyle.GridColor = Color.White;
            dgvtable.ThemeStyle.HeaderStyle.BackColor = Color.Silver;
            dgvtable.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvtable.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvtable.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            dgvtable.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvtable.ThemeStyle.HeaderStyle.Height = 60;
            dgvtable.ThemeStyle.ReadOnly = true;
            dgvtable.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvtable.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvtable.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvtable.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvtable.ThemeStyle.RowsStyle.Height = 70;
            dgvtable.ThemeStyle.RowsStyle.SelectionBackColor = Color.White;
            dgvtable.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            dgvtable.CellClick += dgvtable_CellClick;
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
            // dgvNumber
            // 
            dgvNumber.HeaderText = "Number";
            dgvNumber.MinimumWidth = 6;
            dgvNumber.Name = "dgvNumber";
            dgvNumber.ReadOnly = true;
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
            // dgvCapacity
            // 
            dgvCapacity.HeaderText = "Capacity";
            dgvCapacity.MinimumWidth = 6;
            dgvCapacity.Name = "dgvCapacity";
            dgvCapacity.ReadOnly = true;
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
            // TablesView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 640);
            Controls.Add(dgvtable);
            Name = "TablesView";
            Text = "TablesView";
            Load += TablesView_Load;
            Controls.SetChildIndex(searchText, 0);
            Controls.SetChildIndex(searchLable, 0);
            Controls.SetChildIndex(addBtn, 0);
            Controls.SetChildIndex(HeaderLable, 0);
            Controls.SetChildIndex(dgvtable, 0);
            ((System.ComponentModel.ISupportInitialize)dgvtable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvtable;
        private DataGridViewTextBoxColumn dgvSno;
        private DataGridViewTextBoxColumn dgvId;
        private DataGridViewTextBoxColumn dgvNumber;
        private DataGridViewTextBoxColumn dgvStatus;
        private DataGridViewTextBoxColumn dgvDate;
        private DataGridViewTextBoxColumn dgvCapacity;
        private DataGridViewTextBoxColumn dgvNotes;
        private DataGridViewImageColumn dgvEdit;
        private DataGridViewImageColumn dgvDel;
    }
}