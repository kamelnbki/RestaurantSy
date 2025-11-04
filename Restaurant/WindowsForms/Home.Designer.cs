namespace Restaurant
{
    partial class Home
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
            button2 = new Button();
            Menu_btn = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(254, 237, 218);
            button2.FlatAppearance.BorderColor = Color.FromArgb(199, 128, 10);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 58, 44);
            button2.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(64, 0, 0);
            button2.Location = new Point(725, 852);
            button2.Margin = new Padding(5);
            button2.Name = "button2";
            button2.Size = new Size(263, 65);
            button2.TabIndex = 3;
            button2.Text = "Reserve Table";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Menu_btn
            // 
            Menu_btn.BackColor = Color.FromArgb(64, 0, 0);
            Menu_btn.FlatAppearance.BorderColor = Color.FromArgb(199, 128, 10);
            Menu_btn.FlatAppearance.BorderSize = 2;
            Menu_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 58, 44);
            Menu_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(142, 44, 15);
            Menu_btn.FlatStyle = FlatStyle.Flat;
            Menu_btn.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Menu_btn.ForeColor = Color.FromArgb(237, 201, 118);
            Menu_btn.Location = new Point(457, 712);
            Menu_btn.Margin = new Padding(5);
            Menu_btn.Name = "Menu_btn";
            Menu_btn.Size = new Size(368, 81);
            Menu_btn.TabIndex = 4;
            Menu_btn.Text = "Explore our menu";
            Menu_btn.UseVisualStyleBackColor = false;
            Menu_btn.Click += Menu_btn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(254, 237, 218);
            button1.FlatAppearance.BorderColor = Color.FromArgb(199, 128, 10);
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(160, 58, 44);
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(64, 0, 0);
            button1.Location = new Point(386, 852);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(263, 65);
            button1.TabIndex = 6;
            button1.Text = "New Order";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.lwghw;
            pictureBox1.Location = new Point(496, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox2.Image = Properties.Resources._1758634836946_1_;
            pictureBox2.Location = new Point(185, 329);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(896, 374);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 233, 222);
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1297, 935);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(Menu_btn);
            Controls.Add(button2);
            ForeColor = SystemColors.ActiveCaption;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Home";
            Text = "x";
            TransparencyKey = Color.Gainsboro;
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Menu_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

