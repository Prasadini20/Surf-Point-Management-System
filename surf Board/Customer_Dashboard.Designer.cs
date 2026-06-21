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
            groupBox2 = new GroupBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            pbHeaderLogo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeaderLogo).BeginInit();
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
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientActiveCaption;
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(296, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(817, 420);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(52, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 294);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.GradientActiveCaption;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(392, 141);
            label3.Name = "label3";
            label3.Size = new Size(312, 85);
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
            // Customer_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1162, 619);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Name = "Customer_Dashboard";
            Text = "Customer_Dashboard";
            Load += Customer_Dashboard_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHeaderLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnVIewSerives;
        private Button btnViewSurfboards;
        private Button btnLogout;
        private GroupBox groupBox2;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Button btnMakeBookings;
        private Label label1;
        private PictureBox pbHeaderLogo;
        private PictureBox pictureBox2;
    }
}