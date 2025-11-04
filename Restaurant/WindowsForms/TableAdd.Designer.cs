namespace Restaurant.WindowsForms
{
    partial class TableAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            activeStatus = new CheckBox();
            notesText = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            capacityText = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            numberText = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            clearBut = new Guna.UI2.WinForms.Guna2Button();
            HeaderPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictuer).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.FillColor = Color.FromArgb(192, 192, 255);
            HeaderPanel.ShadowDecoration.CustomizableEdges = customizableEdges1;
            HeaderPanel.Size = new Size(418, 122);
            // 
            // BottomPanel
            // 
            BottomPanel.FillColor = Color.FromArgb(192, 192, 255);
            BottomPanel.Location = new Point(0, 512);
            BottomPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BottomPanel.Size = new Size(418, 94);
            // 
            // pictuer
            // 
            pictuer.Image = Properties.Resources.reservation_table;
            pictuer.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            pictuer.ShadowDecoration.CustomizableEdges = customizableEdges3;
            pictuer.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // closeBtn
            // 
            closeBtn.DialogResult = DialogResult.None;
            closeBtn.DisabledState.BorderColor = Color.DarkGray;
            closeBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            closeBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            // 
            // saveBtn
            // 
            saveBtn.DialogResult = DialogResult.None;
            saveBtn.DisabledState.BorderColor = Color.DarkGray;
            saveBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            saveBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            saveBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            saveBtn.ShadowDecoration.CustomizableEdges = customizableEdges5;
            // 
            // headeLable
            // 
            headerLable.Size = new Size(116, 31);
            headerLable.Text = "Add Table";
            // 
            // activeStatus
            // 
            activeStatus.AutoSize = true;
            activeStatus.Checked = true;
            activeStatus.CheckState = CheckState.Checked;
            activeStatus.Location = new Point(81, 444);
            activeStatus.Name = "activeStatus";
            activeStatus.Size = new Size(78, 27);
            activeStatus.TabIndex = 15;
            activeStatus.Text = "Active";
            activeStatus.UseVisualStyleBackColor = true;
            // 
            // notesText
            // 
            notesText.CustomizableEdges = customizableEdges6;
            notesText.DefaultText = "";
            notesText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            notesText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            notesText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            notesText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            notesText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            notesText.Font = new Font("Segoe UI", 9F);
            notesText.ForeColor = Color.Black;
            notesText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            notesText.Location = new Point(79, 381);
            notesText.Margin = new Padding(3, 4, 3, 4);
            notesText.Name = "notesText";
            notesText.PlaceholderText = "";
            notesText.SelectedText = "";
            notesText.ShadowDecoration.CustomizableEdges = customizableEdges7;
            notesText.Size = new Size(239, 42);
            notesText.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(79, 350);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 13;
            label3.Text = "Notes : ";
            // 
            // capacityText
            // 
            capacityText.CustomizableEdges = customizableEdges8;
            capacityText.DefaultText = "";
            capacityText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            capacityText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            capacityText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            capacityText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            capacityText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            capacityText.Font = new Font("Segoe UI", 9F);
            capacityText.ForeColor = Color.Black;
            capacityText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            capacityText.Location = new Point(79, 282);
            capacityText.Margin = new Padding(3, 4, 3, 4);
            capacityText.Name = "capacityText";
            capacityText.PlaceholderText = "";
            capacityText.SelectedText = "";
            capacityText.ShadowDecoration.CustomizableEdges = customizableEdges9;
            capacityText.Size = new Size(239, 42);
            capacityText.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(79, 251);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 11;
            label2.Text = "Capacity : ";
            // 
            // numberText
            // 
            numberText.CustomizableEdges = customizableEdges10;
            numberText.DefaultText = "";
            numberText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            numberText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            numberText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            numberText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            numberText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            numberText.Font = new Font("Segoe UI", 9F);
            numberText.ForeColor = Color.Black;
            numberText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            numberText.Location = new Point(79, 173);
            numberText.Margin = new Padding(3, 4, 3, 4);
            numberText.Name = "numberText";
            numberText.PlaceholderText = "";
            numberText.SelectedText = "";
            numberText.ShadowDecoration.CustomizableEdges = customizableEdges11;
            numberText.Size = new Size(239, 42);
            numberText.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(79, 142);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 9;
            label1.Text = "Number :";
            // 
            // clearBut
            // 
            clearBut.AutoRoundedCorners = true;
            clearBut.BackColor = Color.Transparent;
            clearBut.CustomizableEdges = customizableEdges12;
            clearBut.DisabledState.BorderColor = Color.DarkGray;
            clearBut.DisabledState.CustomBorderColor = Color.DarkGray;
            clearBut.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clearBut.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clearBut.FillColor = Color.FromArgb(128, 255, 128);
            clearBut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBut.ForeColor = Color.White;
            clearBut.Location = new Point(276, 446);
            clearBut.Name = "clearBut";
            clearBut.ShadowDecoration.CustomizableEdges = customizableEdges13;
            clearBut.Size = new Size(127, 46);
            clearBut.TabIndex = 16;
            clearBut.Text = "Clear Data";
            clearBut.Click += clearBut_Click;
            // 
            // TableAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 606);
            Controls.Add(clearBut);
            Controls.Add(activeStatus);
            Controls.Add(notesText);
            Controls.Add(label3);
            Controls.Add(capacityText);
            Controls.Add(label2);
            Controls.Add(numberText);
            Controls.Add(label1);
            Name = "TableAdd";
            Text = "TableAdd";
            Controls.SetChildIndex(HeaderPanel, 0);
            Controls.SetChildIndex(BottomPanel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(numberText, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(capacityText, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(notesText, 0);
            Controls.SetChildIndex(activeStatus, 0);
            Controls.SetChildIndex(clearBut, 0);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictuer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox activeStatus;
        private Guna.UI2.WinForms.Guna2TextBox notesText;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox capacityText;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox numberText;
        private Label label1;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button clearBut;
    }
}