namespace Restaurant.WindowsForms
{
    partial class CategoryAdd
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
            label1 = new Label();
            nameText = new Guna.UI2.WinForms.Guna2TextBox();
            descriptionText = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            notesText = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            activeStatus = new CheckBox();
            clearBtn = new Guna.UI2.WinForms.Guna2Button();
            HeaderPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictuer).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.FillColor = Color.FromArgb(224, 224, 224);
            HeaderPanel.ShadowDecoration.CustomizableEdges = customizableEdges1;
            HeaderPanel.Size = new Size(418, 122);
            // 
            // BottomPanel
            // 
            BottomPanel.FillColor = Color.FromArgb(224, 224, 224);
            BottomPanel.Location = new Point(0, 503);
            BottomPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BottomPanel.Size = new Size(418, 94);
            // 
            // pictuer
            // 
            pictuer.Image = Properties.Resources.list_timeline;
            pictuer.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Normal;
            pictuer.InitialImage = null;
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
            headerLable.Size = new Size(155, 31);
            headerLable.Text = "Add Category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(73, 150);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 2;
            label1.Text = "Name :";
            // 
            // nameText
            // 
            nameText.CustomizableEdges = customizableEdges6;
            nameText.DefaultText = "";
            nameText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameText.Font = new Font("Segoe UI", 9F);
            nameText.ForeColor = Color.Black;
            nameText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameText.Location = new Point(73, 181);
            nameText.Margin = new Padding(3, 4, 3, 4);
            nameText.Name = "nameText";
            nameText.PlaceholderText = "";
            nameText.SelectedText = "";
            nameText.ShadowDecoration.CustomizableEdges = customizableEdges7;
            nameText.Size = new Size(239, 42);
            nameText.TabIndex = 3;
            // 
            // descriptionText
            // 
            descriptionText.CustomizableEdges = customizableEdges8;
            descriptionText.DefaultText = "";
            descriptionText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            descriptionText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            descriptionText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            descriptionText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            descriptionText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            descriptionText.Font = new Font("Segoe UI", 9F);
            descriptionText.ForeColor = Color.Black;
            descriptionText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            descriptionText.Location = new Point(73, 290);
            descriptionText.Margin = new Padding(3, 4, 3, 4);
            descriptionText.Name = "descriptionText";
            descriptionText.PlaceholderText = "";
            descriptionText.SelectedText = "";
            descriptionText.ShadowDecoration.CustomizableEdges = customizableEdges9;
            descriptionText.Size = new Size(239, 42);
            descriptionText.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(73, 259);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 4;
            label2.Text = "Description : ";
            // 
            // notesText
            // 
            notesText.CustomizableEdges = customizableEdges10;
            notesText.DefaultText = "";
            notesText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            notesText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            notesText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            notesText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            notesText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            notesText.Font = new Font("Segoe UI", 9F);
            notesText.ForeColor = Color.Black;
            notesText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            notesText.Location = new Point(73, 389);
            notesText.Margin = new Padding(3, 4, 3, 4);
            notesText.Name = "notesText";
            notesText.PlaceholderText = "";
            notesText.SelectedText = "";
            notesText.ShadowDecoration.CustomizableEdges = customizableEdges11;
            notesText.Size = new Size(239, 42);
            notesText.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(73, 358);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 6;
            label3.Text = "Notes : ";
            // 
            // activeStatus
            // 
            activeStatus.AutoSize = true;
            activeStatus.Checked = true;
            activeStatus.CheckState = CheckState.Checked;
            activeStatus.Location = new Point(75, 452);
            activeStatus.Name = "activeStatus";
            activeStatus.Size = new Size(78, 27);
            activeStatus.TabIndex = 8;
            activeStatus.Text = "Active";
            activeStatus.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.AutoRoundedCorners = true;
            clearBtn.BackColor = Color.Transparent;
            clearBtn.CustomizableEdges = customizableEdges12;
            clearBtn.DisabledState.BorderColor = Color.DarkGray;
            clearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            clearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clearBtn.FillColor = Color.FromArgb(128, 255, 128);
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(266, 444);
            clearBtn.Name = "clearBtn";
            clearBtn.ShadowDecoration.CustomizableEdges = customizableEdges13;
            clearBtn.Size = new Size(127, 46);
            clearBtn.TabIndex = 9;
            clearBtn.Text = "Clear Data";
            clearBtn.Click += clearBtn_Click;
            // 
            // CategoryAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 597);
            Controls.Add(clearBtn);
            Controls.Add(activeStatus);
            Controls.Add(notesText);
            Controls.Add(label3);
            Controls.Add(descriptionText);
            Controls.Add(label2);
            Controls.Add(nameText);
            Controls.Add(label1);
            Name = "CategoryAdd";
            Text = "CategoryAdd";
            Controls.SetChildIndex(HeaderPanel, 0);
            Controls.SetChildIndex(BottomPanel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(nameText, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(descriptionText, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(notesText, 0);
            Controls.SetChildIndex(activeStatus, 0);
            Controls.SetChildIndex(clearBtn, 0);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictuer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
        private Guna.UI2.WinForms.Guna2TextBox descriptionText;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox notesText;
        private Label label3;
        private CheckBox activeStatus;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        public Guna.UI2.WinForms.Guna2Button clearBtn;
    }
}