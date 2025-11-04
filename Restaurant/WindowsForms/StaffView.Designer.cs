namespace Restaurant.WindowsForms
{
    partial class StaffView
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
            SuspendLayout();
            // 
            // HeaderLable
            // 
            HeaderLable.Location = new Point(30, 25);
            HeaderLable.Size = new Size(104, 32);
            HeaderLable.Text = "Staff List";
            // 
            // searchText
            // 
            searchText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            searchText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            searchText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            searchText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            searchText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            searchText.Location = new Point(1056, 81);
            searchText.ShadowDecoration.CustomizableEdges = customizableEdges1;
            searchText.Size = new Size(269, 53);
            // 
            // addBtn
            // 
            addBtn.CheckedState.ImageSize = new Size(64, 64);
            addBtn.DialogResult = DialogResult.None;
            addBtn.HoverState.ImageSize = new Size(64, 64);
            addBtn.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            addBtn.Location = new Point(43, 72);
            addBtn.PressedState.ImageSize = new Size(64, 64);
            addBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            // 
            // searchLable
            // 
            searchLable.Location = new Point(1056, 48);
            // 
            // StaffView
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 594);
            Name = "StaffView";
            Text = "StaffView";
            Load += StaffView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}