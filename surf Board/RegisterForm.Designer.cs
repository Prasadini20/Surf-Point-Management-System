namespace surf_Board
{
    partial class RegisterForm
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
            this.txtRegFullName = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegContact = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.btnRegisterSubmit = new System.Windows.Forms.Button();
            this.lnkBackToLogin = new System.Windows.Forms.LinkLabel();
            this.registrationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.registrationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRegFullName
            // 
            this.txtRegFullName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegFullName.Location = new System.Drawing.Point(79, 170);
            this.txtRegFullName.Multiline = true;
            this.txtRegFullName.Name = "txtRegFullName";
            this.txtRegFullName.Size = new System.Drawing.Size(282, 37);
            this.txtRegFullName.TabIndex = 0;
            this.txtRegFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRegFullName.TextChanged += new System.EventHandler(this.txtRegFullName_TextChanged);
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(423, 170);
            this.txtRegUsername.Multiline = true;
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(260, 37);
            this.txtRegUsername.TabIndex = 1;
            // 
            // txtRegContact
            // 
            this.txtRegContact.Location = new System.Drawing.Point(79, 294);
            this.txtRegContact.Multiline = true;
            this.txtRegContact.Name = "txtRegContact";
            this.txtRegContact.Size = new System.Drawing.Size(282, 32);
            this.txtRegContact.TabIndex = 2;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(423, 294);
            this.txtRegPassword.Multiline = true;
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(260, 32);
            this.txtRegPassword.TabIndex = 3;
            this.txtRegPassword.TextChanged += new System.EventHandler(this.txtRegPassword_TextChanged);
            // 
            // btnRegisterSubmit
            // 
            this.btnRegisterSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegisterSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterSubmit.Location = new System.Drawing.Point(233, 392);
            this.btnRegisterSubmit.Name = "btnRegisterSubmit";
            this.btnRegisterSubmit.Size = new System.Drawing.Size(332, 37);
            this.btnRegisterSubmit.TabIndex = 5;
            this.btnRegisterSubmit.Text = "REGISTER";
            this.btnRegisterSubmit.UseVisualStyleBackColor = false;
            this.btnRegisterSubmit.Click += new System.EventHandler(this.btnRegisterSubmit_Click);
            // 
            // lnkBackToLogin
            // 
            this.lnkBackToLogin.AutoSize = true;
            this.lnkBackToLogin.Location = new System.Drawing.Point(300, 461);
            this.lnkBackToLogin.Name = "lnkBackToLogin";
            this.lnkBackToLogin.Size = new System.Drawing.Size(198, 16);
            this.lnkBackToLogin.TabIndex = 6;
            this.lnkBackToLogin.TabStop = true;
            this.lnkBackToLogin.Text = "Already have an account? Login";
            this.lnkBackToLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBackToLogin_LinkClicked);
            // 
            // registrationPanel
            // 
            this.registrationPanel.Controls.Add(this.label6);
            this.registrationPanel.Controls.Add(this.label5);
            this.registrationPanel.Controls.Add(this.label4);
            this.registrationPanel.Controls.Add(this.label3);
            this.registrationPanel.Controls.Add(this.label1);
            this.registrationPanel.Controls.Add(this.txtRegUsername);
            this.registrationPanel.Controls.Add(this.txtRegFullName);
            this.registrationPanel.Controls.Add(this.lnkBackToLogin);
            this.registrationPanel.Controls.Add(this.txtRegContact);
            this.registrationPanel.Controls.Add(this.btnRegisterSubmit);
            this.registrationPanel.Controls.Add(this.txtRegPassword);
            this.registrationPanel.Location = new System.Drawing.Point(138, 51);
            this.registrationPanel.Name = "registrationPanel";
            this.registrationPanel.Size = new System.Drawing.Size(752, 521);
            this.registrationPanel.TabIndex = 7;
            this.registrationPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.registrationPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "FULL NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "CONTACT NUMBER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "USERNAME";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(427, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "PASSWORD";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::surf_Board.Properties.Resources._64db8df80ac058d0ee6ff119a0965e8f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.registrationPanel);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.registrationPanel.ResumeLayout(false);
            this.registrationPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegFullName;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.TextBox txtRegContact;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.Button btnRegisterSubmit;
        private System.Windows.Forms.LinkLabel lnkBackToLogin;
        private System.Windows.Forms.Panel registrationPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}