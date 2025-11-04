namespace Restaurant.WindowsForms
{
    partial class Login
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
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            userNameText = new TextBox();
            passwordText = new TextBox();
            label2 = new Label();
            loginBtn = new Guna.UI2.WinForms.Guna2Button();
            exitBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(pictureBox1);
            guna2Panel1.Controls.Add(label3);
            guna2Panel1.CustomizableEdges = customizableEdges1;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.FillColor = Color.FromArgb(224, 224, 224);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Panel1.Size = new Size(508, 284);
            guna2Panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.User3;
            pictureBox1.Location = new Point(195, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 121);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(269, 28);
            label3.TabIndex = 2;
            label3.Text = "Please enter user information.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 331);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 28);
            label1.TabIndex = 5;
            label1.Text = "User Name : ";
            // 
            // userNameText
            // 
            userNameText.Location = new Point(55, 363);
            userNameText.Margin = new Padding(4);
            userNameText.Multiline = true;
            userNameText.Name = "userNameText";
            userNameText.Size = new Size(393, 55);
            userNameText.TabIndex = 0;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(55, 486);
            passwordText.Margin = new Padding(4);
            passwordText.Multiline = true;
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(393, 55);
            passwordText.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 454);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 6;
            label2.Text = "Password :";
            // 
            // loginBtn
            // 
            loginBtn.AutoRoundedCorners = true;
            loginBtn.CustomizableEdges = customizableEdges3;
            loginBtn.DisabledState.BorderColor = Color.DarkGray;
            loginBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            loginBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            loginBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            loginBtn.FillColor = Color.FromArgb(255, 50, 128);
            loginBtn.Font = new Font("Segoe UI", 12F);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(55, 576);
            loginBtn.Name = "loginBtn";
            loginBtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            loginBtn.Size = new Size(191, 64);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.Click += loginBtn_Click;
            // 
            // exitBtn
            // 
            exitBtn.AutoRoundedCorners = true;
            exitBtn.CustomizableEdges = customizableEdges5;
            exitBtn.DisabledState.BorderColor = Color.DarkGray;
            exitBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            exitBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exitBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exitBtn.FillColor = Color.Red;
            exitBtn.Font = new Font("Segoe UI", 12F);
            exitBtn.ForeColor = Color.White;
            exitBtn.Location = new Point(257, 576);
            exitBtn.Name = "exitBtn";
            exitBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exitBtn.Size = new Size(191, 64);
            exitBtn.TabIndex = 3;
            exitBtn.Text = "Exit";
            exitBtn.Click += exitBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 702);
            Controls.Add(exitBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(passwordText);
            Controls.Add(userNameText);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private TextBox userNameText;
        private TextBox passwordText;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Button loginBtn;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private PictureBox pictureBox1;
    }
}