namespace surf_Board
{
    partial class Customer_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Dashboard));
            panel1 = new Panel();
            btnMakeBookings = new Button();
            btnVIewSerives = new Button();
            btnViewSurfboards = new Button();
            btnLogout = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            pbHeaderLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox4 = new GroupBox();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            label6 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeaderLogo).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(btnMakeBookings);
            panel1.Controls.Add(btnVIewSerives);
            panel1.Controls.Add(btnViewSurfboards);
            panel1.Location = new Point(3, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 549);
            panel1.TabIndex = 0;
            // 
            // btnMakeBookings
            // 
            btnMakeBookings.BackColor = Color.LightGray;
            btnMakeBookings.Location = new Point(48, 48);
            btnMakeBookings.Name = "btnMakeBookings";
            btnMakeBookings.Size = new Size(159, 29);
            btnMakeBookings.TabIndex = 4;
            btnMakeBookings.Text = "Make Bookings";
            btnMakeBookings.UseVisualStyleBackColor = false;
            btnMakeBookings.Click += btnMakeBookings_Click;
            // 
            // btnVIewSerives
            // 
            btnVIewSerives.BackColor = Color.LightGray;
            btnVIewSerives.Location = new Point(48, 256);
            btnVIewSerives.Name = "btnVIewSerives";
            btnVIewSerives.Size = new Size(159, 29);
            btnVIewSerives.TabIndex = 3;
            btnVIewSerives.Text = "View Services";
            btnVIewSerives.UseVisualStyleBackColor = false;
            btnVIewSerives.UseWaitCursor = true;
            btnVIewSerives.Click += btnViewServices_Click;
            // 
            // btnViewSurfboards
            // 
            btnViewSurfboards.BackColor = Color.LightGray;
            btnViewSurfboards.Location = new Point(48, 156);
            btnViewSurfboards.Name = "btnViewSurfboards";
            btnViewSurfboards.Size = new Size(159, 29);
            btnViewSurfboards.TabIndex = 2;
            btnViewSurfboards.Text = "View Surfboards";
            btnViewSurfboards.UseVisualStyleBackColor = false;
            btnViewSurfboards.Click += btnViewSurfboards_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Location = new Point(1042, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(265, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(415, 124);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(145, 84);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 10;
            label7.Text = "1";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(55, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 59);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 49);
            label4.Name = "label4";
            label4.Size = new Size(113, 20);
            label4.TabIndex = 8;
            label4.Text = "Total Bookings";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(320, 296);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(587, 234);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 158);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(282, 92);
            label3.Name = "label3";
            label3.Size = new Size(275, 70);
            label3.TabIndex = 7;
            label3.Text = "Book your favorite surfboards easily,check available boards and view the available services";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SteelBlue;
            panel2.Controls.Add(pbHeaderLogo);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLogout);
            panel2.Location = new Point(3, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1159, 84);
            panel2.TabIndex = 5;
            // 
            // pbHeaderLogo
            // 
            pbHeaderLogo.BackColor = Color.SteelBlue;
            pbHeaderLogo.Image = (Image)resources.GetObject("pbHeaderLogo.Image");
            pbHeaderLogo.Location = new Point(48, 3);
            pbHeaderLogo.Name = "pbHeaderLogo";
            pbHeaderLogo.Size = new Size(80, 74);
            pbHeaderLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHeaderLogo.TabIndex = 3;
            pbHeaderLogo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 23);
            label1.Name = "label1";
            label1.Size = new Size(371, 38);
            label1.TabIndex = 2;
            label1.Text = "Welcome to the Aqua Ride";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 89);
            label2.Name = "label2";
            label2.Size = new Size(273, 38);
            label2.TabIndex = 6;
            label2.Text = "Dashboard Overview";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.GradientActiveCaption;
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(pictureBox5);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(713, 133);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(389, 125);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(130, 81);
            label9.Name = "label9";
            label9.Size = new Size(17, 20);
            label9.TabIndex = 11;
            label9.Text = "3";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(51, 26);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(36, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(111, 46);
            label6.Name = "label6";
            label6.Size = new Size(100, 20);
            label6.TabIndex = 1;
            label6.Text = "Last Booking";
            // 
            // Customer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1162, 619);
            Controls.Add(groupBox4);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Customer_Dashboard";
            Text = "Customer_Dashboard";
            Load += Customer_Dashboard_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeaderLogo).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVIewSerives;
        private Button btnViewSurfboards;
        private Button btnLogout;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox4;
        private Button btnMakeBookings;
        private Label label6;
        private Label label1;
        private PictureBox pbHeaderLogo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private Label label7;
        private Label label9;
    }
}