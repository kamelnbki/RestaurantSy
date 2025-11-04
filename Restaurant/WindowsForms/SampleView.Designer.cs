namespace Restaurant.WindowsForms
{
    partial class SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            searchText = new Guna.UI2.WinForms.Guna2TextBox();
            searchLable = new Label();
            addBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            HeaderLable = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // searchText
            // 
            searchText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchText.CustomizableEdges = customizableEdges1;
            searchText.DefaultText = "";
            searchText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.Font = new Font("Segoe UI", 11F);
            searchText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.IconLeft = Properties.Resources.insight_head;
            searchText.Location = new Point(728, 81);
            searchText.Margin = new Padding(4, 5, 4, 5);
            searchText.Name = "searchText";
            searchText.PlaceholderText = "Search Here";
            searchText.SelectedText = "";
            searchText.ShadowDecoration.CustomizableEdges = customizableEdges2;
            searchText.Size = new Size(626, 53);
            searchText.TabIndex = 0;
            searchText.TextChanged += searchText_TextChanged;
            // 
            // searchLable
            // 
            searchLable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchLable.AutoSize = true;
            searchLable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchLable.Location = new Point(728, 48);
            searchLable.Name = "searchLable";
            searchLable.Size = new Size(75, 28);
            searchLable.TabIndex = 1;
            searchLable.Text = "Search";
            // 
            // addBtn
            // 
            addBtn.CheckedState.ImageSize = new Size(64, 64);
            addBtn.HoverState.ImageSize = new Size(64, 64);
            addBtn.Image = (Image)resources.GetObject("addBtn.Image");
            addBtn.ImageOffset = new Point(0, 0);
            addBtn.ImageRotate = 0F;
            addBtn.Location = new Point(55, 72);
            addBtn.Name = "addBtn";
            addBtn.PressedState.ImageSize = new Size(64, 64);
            addBtn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            addBtn.Size = new Size(61, 62);
            addBtn.TabIndex = 2;
            addBtn.Click += addBtn_Click;
            // 
            // HeaderLable
            // 
            HeaderLable.AutoSize = true;
            HeaderLable.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderLable.Location = new Point(42, 25);
            HeaderLable.Name = "HeaderLable";
            HeaderLable.Size = new Size(141, 32);
            HeaderLable.TabIndex = 3;
            HeaderLable.Text = "Header Text";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            guna2Separator1.Location = new Point(12, 160);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1353, 22);
            guna2Separator1.TabIndex = 5;
            // 
            // SampleView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1377, 747);
            Controls.Add(guna2Separator1);
            Controls.Add(HeaderLable);
            Controls.Add(addBtn);
            Controls.Add(searchLable);
            Controls.Add(searchText);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "SampleView";
            Text = "SampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        public Label HeaderLable;
        public Guna.UI2.WinForms.Guna2TextBox searchText;
        public Guna.UI2.WinForms.Guna2ImageButton addBtn;
        public Label searchLable;
    }
}