namespace Surfing_Management_System
{
    partial class Form1
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
            this.txtUsername_ = new System.Windows.Forms.TextBox();
            this.txtPassword_ = new System.Windows.Forms.TextBox();
            this.chkShowPassword_ = new System.Windows.Forms.CheckBox();
            this.lnkForgotPassword_ = new System.Windows.Forms.LinkLabel();
            this.btnLogin_ = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsername_
            // 
            this.txtUsername_.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsername_.Location = new System.Drawing.Point(443, 93);
            this.txtUsername_.Multiline = true;
            this.txtUsername_.Name = "txtUsername_";
            this.txtUsername_.Size = new System.Drawing.Size(255, 33);
            this.txtUsername_.TabIndex = 0;
            // 
            // txtPassword_
            // 
            this.txtPassword_.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPassword_.Location = new System.Drawing.Point(443, 169);
            this.txtPassword_.Name = "txtPassword_";
            this.txtPassword_.Size = new System.Drawing.Size(255, 22);
            this.txtPassword_.TabIndex = 1;
            this.txtPassword_.UseSystemPasswordChar = true;
            this.txtPassword_.TextChanged += new System.EventHandler(this.txtPassword__TextChanged);
            // 
            // chkShowPassword_
            // 
            this.chkShowPassword_.AutoSize = true;
            this.chkShowPassword_.Location = new System.Drawing.Point(398, 223);
            this.chkShowPassword_.Name = "chkShowPassword_";
            this.chkShowPassword_.Size = new System.Drawing.Size(125, 20);
            this.chkShowPassword_.TabIndex = 2;
            this.chkShowPassword_.Text = "Show Password";
            this.chkShowPassword_.UseVisualStyleBackColor = true;
            this.chkShowPassword_.CheckedChanged += new System.EventHandler(this.chkShowPassword__CheckedChanged);
            // 
            // lnkForgotPassword_
            // 
            this.lnkForgotPassword_.AutoSize = true;
            this.lnkForgotPassword_.Location = new System.Drawing.Point(628, 223);
            this.lnkForgotPassword_.Name = "lnkForgotPassword_";
            this.lnkForgotPassword_.Size = new System.Drawing.Size(109, 16);
            this.lnkForgotPassword_.TabIndex = 3;
            this.lnkForgotPassword_.TabStop = true;
            this.lnkForgotPassword_.Text = "Forgot Password";
            this.lnkForgotPassword_.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgotPassword__Click);
            // 
            // btnLogin_
            // 
            this.btnLogin_.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin_.Location = new System.Drawing.Point(523, 300);
            this.btnLogin_.Name = "btnLogin_";
            this.btnLogin_.Size = new System.Drawing.Size(84, 30);
            this.btnLogin_.TabIndex = 4;
            this.btnLogin_.Text = "LOGIN";
            this.btnLogin_.UseVisualStyleBackColor = false;
            this.btnLogin_.Click += new System.EventHandler(this.btnLogin__Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(420, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(420, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Surfing_Management_System.Properties.Resources.c0cfd94ad9887cfa3dd1cddd40d32f9e;
            this.pictureBox1.Location = new System.Drawing.Point(-51, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 403);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin_);
            this.Controls.Add(this.lnkForgotPassword_);
            this.Controls.Add(this.chkShowPassword_);
            this.Controls.Add(this.txtPassword_);
            this.Controls.Add(this.txtUsername_);
            this.Name = "Form1";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.TextBox txtUsername_;
        private System.Windows.Forms.TextBox txtPassword_;
        private System.Windows.Forms.CheckBox chkShowPassword_;
        private System.Windows.Forms.LinkLabel lnkForgotPassword_;
        private System.Windows.Forms.Button btnLogin_;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

