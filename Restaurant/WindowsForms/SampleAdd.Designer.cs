namespace Restaurant.WindowsForms
{
    partial class SampleAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            HeaderPanel = new Guna.UI2.WinForms.Guna2Panel();
            headerLable = new Label();
            pictuer = new Guna.UI2.WinForms.Guna2PictureBox();
            BottomPanel = new Guna.UI2.WinForms.Guna2Panel();
            closeBtn = new Guna.UI2.WinForms.Guna2Button();
            saveBtn = new Guna.UI2.WinForms.Guna2Button();
            HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictuer).BeginInit();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.Controls.Add(headerLable);
            HeaderPanel.Controls.Add(pictuer);
            HeaderPanel.CustomizableEdges = customizableEdges3;
            HeaderPanel.Dock = DockStyle.Top;
            HeaderPanel.FillColor = Color.FromArgb(255, 255, 192);
            HeaderPanel.Location = new Point(0, 0);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            HeaderPanel.Size = new Size(765, 122);
            HeaderPanel.TabIndex = 0;
            // 
            // headerLable
            // 
            headerLable.AutoSize = true;
            headerLable.BackColor = Color.Transparent;
            headerLable.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLable.Location = new Point(153, 48);
            headerLable.Name = "headerLable";
            headerLable.Size = new Size(88, 31);
            headerLable.TabIndex = 1;
            headerLable.Text = "Header";
            headerLable.Click += headerLable_Click;
            // 
            // pictuer
            // 
            pictuer.BackColor = Color.Transparent;
            pictuer.CustomizableEdges = customizableEdges1;
            pictuer.ImageRotate = 0F;
            pictuer.Location = new Point(21, 18);
            pictuer.Name = "pictuer";
            pictuer.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictuer.Size = new Size(104, 87);
            pictuer.TabIndex = 0;
            pictuer.TabStop = false;
            // 
            // BottomPanel
            // 
            BottomPanel.Controls.Add(closeBtn);
            BottomPanel.Controls.Add(saveBtn);
            BottomPanel.CustomizableEdges = customizableEdges9;
            BottomPanel.Dock = DockStyle.Bottom;
            BottomPanel.FillColor = Color.FromArgb(255, 255, 202);
            BottomPanel.Location = new Point(0, 372);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            BottomPanel.Size = new Size(765, 94);
            BottomPanel.TabIndex = 1;
            // 
            // closeBtn
            // 
            closeBtn.AutoRoundedCorners = true;
            closeBtn.BackColor = Color.Transparent;
            customizableEdges5.TopRight = false;
            closeBtn.CustomizableEdges = customizableEdges5;
            closeBtn.DisabledState.BorderColor = Color.DarkGray;
            closeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            closeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeBtn.FillColor = Color.FromArgb(128, 128, 255);
            closeBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.White;
            closeBtn.Location = new Point(172, 20);
            closeBtn.Name = "closeBtn";
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            closeBtn.Size = new Size(140, 56);
            closeBtn.TabIndex = 3;
            closeBtn.Text = "Close";
            closeBtn.Click += closeBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.AutoRoundedCorners = true;
            saveBtn.BackColor = Color.Transparent;
            customizableEdges7.TopRight = false;
            saveBtn.CustomizableEdges = customizableEdges7;
            saveBtn.DisabledState.BorderColor = Color.DarkGray;
            saveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            saveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            saveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            saveBtn.FillColor = Color.Fuchsia;
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(12, 20);
            saveBtn.Name = "saveBtn";
            saveBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            saveBtn.Size = new Size(140, 56);
            saveBtn.TabIndex = 2;
            saveBtn.Text = "Save";
            saveBtn.Click += saveBtn_Click;
            // 
            // SampleAdd
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(765, 466);
            Controls.Add(BottomPanel);
            Controls.Add(HeaderPanel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "SampleAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SampleAdd";
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictuer).EndInit();
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Guna.UI2.WinForms.Guna2Panel HeaderPanel;
        public Guna.UI2.WinForms.Guna2Panel BottomPanel;
        public Guna.UI2.WinForms.Guna2PictureBox pictuer;
        public Guna.UI2.WinForms.Guna2Button closeBtn;
        public Guna.UI2.WinForms.Guna2Button saveBtn;
        public Label headerLable;
    }
}