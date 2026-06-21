namespace surf_Board
{
    partial class Admin_Dashboard
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
            panel1 = new Panel();
            btnLogout = new Button();
            btnSurfboardManagement = new Button();
            btnInstructorManagement = new Button();
            btnCustomerManagement = new Button();
            btnDashHome = new Button();
            panelMainContent = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pnlCardSurf = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            pnlCardInst = new Panel();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label1 = new Label();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            panelMainContent.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCardSurf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlCardInst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(14, 43, 89);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnSurfboardManagement);
            panel1.Controls.Add(btnInstructorManagement);
            panel1.Controls.Add(btnCustomerManagement);
            panel1.Controls.Add(btnDashHome);
            panel1.Dock = DockStyle.Left;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 734);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Crimson;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(12, 640);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(210, 61);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSurfboardManagement
            // 
            btnSurfboardManagement.FlatStyle = FlatStyle.Flat;
            btnSurfboardManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSurfboardManagement.ForeColor = SystemColors.ButtonHighlight;
            btnSurfboardManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnSurfboardManagement.Location = new Point(0, 240);
            btnSurfboardManagement.Margin = new Padding(3, 4, 3, 4);
            btnSurfboardManagement.Name = "btnSurfboardManagement";
            btnSurfboardManagement.Size = new Size(240, 66);
            btnSurfboardManagement.TabIndex = 3;
            btnSurfboardManagement.Text = "Surfboard Management";
            btnSurfboardManagement.UseVisualStyleBackColor = true;
            btnSurfboardManagement.Click += btnSurfboardManagement_Click;
            // 
            // btnInstructorManagement
            // 
            btnInstructorManagement.FlatStyle = FlatStyle.Flat;
            btnInstructorManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstructorManagement.ForeColor = SystemColors.ButtonHighlight;
            btnInstructorManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnInstructorManagement.Location = new Point(-4, 172);
            btnInstructorManagement.Margin = new Padding(3, 4, 3, 4);
            btnInstructorManagement.Name = "btnInstructorManagement";
            btnInstructorManagement.Size = new Size(244, 71);
            btnInstructorManagement.TabIndex = 2;
            btnInstructorManagement.Text = "Instructor Management";
            btnInstructorManagement.UseVisualStyleBackColor = true;
            btnInstructorManagement.Click += btnInstructorManagement_Click;
            // 
            // btnCustomerManagement
            // 
            btnCustomerManagement.FlatStyle = FlatStyle.Flat;
            btnCustomerManagement.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomerManagement.ForeColor = SystemColors.ButtonHighlight;
            btnCustomerManagement.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomerManagement.Location = new Point(0, 114);
            btnCustomerManagement.Margin = new Padding(3, 4, 3, 4);
            btnCustomerManagement.Name = "btnCustomerManagement";
            btnCustomerManagement.Size = new Size(240, 62);
            btnCustomerManagement.TabIndex = 1;
            btnCustomerManagement.Text = "Customer Management";
            btnCustomerManagement.UseVisualStyleBackColor = true;
            btnCustomerManagement.Click += btnCustomerManagement_Click;
            // 
            // btnDashHome
            // 
            btnDashHome.FlatStyle = FlatStyle.Flat;
            btnDashHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashHome.ForeColor = SystemColors.ButtonHighlight;
            btnDashHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashHome.Location = new Point(-4, 54);
            btnDashHome.Margin = new Padding(3, 4, 3, 4);
            btnDashHome.Name = "btnDashHome";
            btnDashHome.Size = new Size(244, 65);
            btnDashHome.TabIndex = 0;
            btnDashHome.Text = "Dashboard";
            btnDashHome.UseVisualStyleBackColor = true;
            // 
            // panelMainContent
            // 
            panelMainContent.BackColor = Color.FromArgb(245, 247, 250);
            panelMainContent.Controls.Add(panel3);
            panelMainContent.Controls.Add(pnlCardSurf);
            panelMainContent.Controls.Add(pnlCardInst);
            panelMainContent.Controls.Add(label1);
            panelMainContent.Controls.Add(lblWelcome);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(240, 0);
            panelMainContent.Margin = new Padding(3, 4, 3, 4);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(753, 734);
            panelMainContent.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(44, 184);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(320, 224);
            panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Custimages;
            pictureBox1.Location = new Point(102, 45);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(83, 138);
            label2.Name = "label2";
            label2.Size = new Size(158, 56);
            label2.TabIndex = 0;
            label2.Text = "   CUSTOMER\r\nMANAGEMENT";
            // 
            // pnlCardSurf
            // 
            pnlCardSurf.BorderStyle = BorderStyle.Fixed3D;
            pnlCardSurf.Controls.Add(pictureBox3);
            pnlCardSurf.Controls.Add(label3);
            pnlCardSurf.Location = new Point(41, 441);
            pnlCardSurf.Margin = new Padding(3, 4, 3, 4);
            pnlCardSurf.Name = "pnlCardSurf";
            pnlCardSurf.Size = new Size(320, 224);
            pnlCardSurf.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.surf;
            pictureBox3.Location = new Point(105, 34);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(114, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(86, 126);
            label3.Name = "label3";
            label3.Size = new Size(158, 56);
            label3.TabIndex = 0;
            label3.Text = "  SURFBOARD\r\nMANAGEMENT\r\n";
            // 
            // pnlCardInst
            // 
            pnlCardInst.BorderStyle = BorderStyle.Fixed3D;
            pnlCardInst.Controls.Add(pictureBox2);
            pnlCardInst.Controls.Add(label4);
            pnlCardInst.Location = new Point(391, 184);
            pnlCardInst.Margin = new Padding(3, 4, 3, 4);
            pnlCardInst.Name = "pnlCardInst";
            pnlCardInst.Size = new Size(320, 224);
            pnlCardInst.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.instr;
            pictureBox2.Location = new Point(106, 45);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(114, 89);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(88, 138);
            label4.Name = "label4";
            label4.Size = new Size(147, 56);
            label4.TabIndex = 0;
            label4.Text = " INSTRUCTOR \r\nMANAGMENT";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(36, 88);
            label1.Name = "label1";
            label1.Size = new Size(249, 25);
            label1.TabIndex = 1;
            label1.Text = "Manage all system operations";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.FromArgb(14, 43, 89);
            lblWelcome.Location = new Point(22, 24);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(342, 50);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "WELCOME ADMIN";
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 734);
            Controls.Add(panelMainContent);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            panel1.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            panelMainContent.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCardSurf.ResumeLayout(false);
            pnlCardSurf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlCardInst.ResumeLayout(false);
            pnlCardInst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInstructorManagement;
        private System.Windows.Forms.Button btnCustomerManagement;
        private System.Windows.Forms.Button btnDashHome;
        private System.Windows.Forms.Button btnSurfboardManagement;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelMainContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlCardSurf;
        private System.Windows.Forms.Panel pnlCardInst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}