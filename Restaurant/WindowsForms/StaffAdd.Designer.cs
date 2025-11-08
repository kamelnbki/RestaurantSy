namespace Restaurant.WindowsForms
{
    partial class StaffAdd
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
            clearBtn = new Guna.UI2.WinForms.Guna2Button();
            activeStatus = new CheckBox();
            phoneText = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            nameText = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            label4 = new Label();
            roleComBox = new ComboBox();
            HeaderPanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictuer).BeginInit();
            SuspendLayout();
            // 
            // HeaderPanel
            // 
            HeaderPanel.FillColor = Color.FromArgb(224, 224, 224);
            HeaderPanel.ShadowDecoration.CustomizableEdges = customizableEdges1;
            HeaderPanel.Size = new Size(422, 122);
            // 
            // BottomPanel
            // 
            BottomPanel.FillColor = Color.FromArgb(224, 224, 224);
            BottomPanel.Location = new Point(0, 548);
            BottomPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            BottomPanel.Size = new Size(422, 94);
            // 
            // pictuer
            // 
            pictuer.Image = Properties.Resources.team__1_;
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
            // headerLable
            // 
            headerLable.Size = new Size(108, 31);
            headerLable.Text = "Add Staff";
            // 
            // clearBtn
            // 
            clearBtn.AutoRoundedCorners = true;
            clearBtn.BackColor = Color.Transparent;
            clearBtn.CustomizableEdges = customizableEdges6;
            clearBtn.DisabledState.BorderColor = Color.DarkGray;
            clearBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            clearBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            clearBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            clearBtn.FillColor = Color.FromArgb(128, 255, 128);
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = Color.White;
            clearBtn.Location = new Point(252, 477);
            clearBtn.Name = "clearBtn";
            clearBtn.ShadowDecoration.CustomizableEdges = customizableEdges7;
            clearBtn.Size = new Size(127, 46);
            clearBtn.TabIndex = 17;
            clearBtn.Text = "Clear Data";
            clearBtn.Click += clearBtn_Click;
            // 
            // activeStatus
            // 
            activeStatus.AutoSize = true;
            activeStatus.Checked = true;
            activeStatus.CheckState = CheckState.Checked;
            activeStatus.Location = new Point(61, 485);
            activeStatus.Name = "activeStatus";
            activeStatus.Size = new Size(78, 27);
            activeStatus.TabIndex = 16;
            activeStatus.Text = "Active";
            activeStatus.UseVisualStyleBackColor = true;
            // 
            // phoneText
            // 
            phoneText.CustomizableEdges = customizableEdges8;
            phoneText.DefaultText = "";
            phoneText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            phoneText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            phoneText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            phoneText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            phoneText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            phoneText.Font = new Font("Segoe UI", 9F);
            phoneText.ForeColor = Color.Black;
            phoneText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            phoneText.Location = new Point(62, 297);
            phoneText.Margin = new Padding(3, 4, 3, 4);
            phoneText.Name = "phoneText";
            phoneText.PlaceholderText = "";
            phoneText.SelectedText = "";
            phoneText.ShadowDecoration.CustomizableEdges = customizableEdges9;
            phoneText.Size = new Size(239, 42);
            phoneText.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(62, 266);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 12;
            label2.Text = "Phone Number :";
            // 
            // nameText
            // 
            nameText.CustomizableEdges = customizableEdges10;
            nameText.DefaultText = "";
            nameText.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            nameText.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            nameText.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            nameText.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            nameText.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            nameText.Font = new Font("Segoe UI", 9F);
            nameText.ForeColor = Color.Black;
            nameText.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            nameText.Location = new Point(62, 188);
            nameText.Margin = new Padding(3, 4, 3, 4);
            nameText.Name = "nameText";
            nameText.PlaceholderText = "";
            nameText.SelectedText = "";
            nameText.ShadowDecoration.CustomizableEdges = customizableEdges11;
            nameText.Size = new Size(239, 42);
            nameText.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(62, 157);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 10;
            label1.Text = "Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(62, 373);
            label4.Name = "label4";
            label4.Size = new Size(52, 23);
            label4.TabIndex = 18;
            label4.Text = "Role :";
            // 
            // roleComBox
            // 
            roleComBox.FormattingEnabled = true;
            roleComBox.Location = new Point(62, 409);
            roleComBox.Name = "roleComBox";
            roleComBox.Size = new Size(239, 31);
            roleComBox.TabIndex = 19;
            // 
            // StaffAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 642);
            Controls.Add(roleComBox);
            Controls.Add(label4);
            Controls.Add(clearBtn);
            Controls.Add(activeStatus);
            Controls.Add(phoneText);
            Controls.Add(label2);
            Controls.Add(nameText);
            Controls.Add(label1);
            Name = "StaffAdd";
            Text = "StaffAdd";
            Controls.SetChildIndex(HeaderPanel, 0);
            Controls.SetChildIndex(BottomPanel, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(nameText, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(phoneText, 0);
            Controls.SetChildIndex(activeStatus, 0);
            Controls.SetChildIndex(clearBtn, 0);
            Controls.SetChildIndex(label4, 0);
            Controls.SetChildIndex(roleComBox, 0);
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictuer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button clearBtn;
        private CheckBox activeStatus;
        private Guna.UI2.WinForms.Guna2TextBox notesText;
        private Label label3;
        private Guna.UI2.WinForms.Guna2TextBox phoneText;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox nameText;
        private Label label1;
        private Label label4;
        private ComboBox roleComBox;
    }
}