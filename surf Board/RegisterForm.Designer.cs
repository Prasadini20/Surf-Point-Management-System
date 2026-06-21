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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txtRegFullName = new TextBox();
            txtRegUsername = new TextBox();
            txtRegContact = new TextBox();
            txtRegPassword = new TextBox();
            btnRegisterSubmit = new Button();
            lnkBackToLogin = new LinkLabel();
            registrationPanel = new Panel();
            comboBox1 = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            txtRegEmail = new TextBox();
            txtRegCountry = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            registrationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // txtRegFullName
            // 
            txtRegFullName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRegFullName.Location = new Point(220, 104);
            txtRegFullName.Margin = new Padding(3, 4, 3, 4);
            txtRegFullName.Multiline = true;
            txtRegFullName.Name = "txtRegFullName";
            txtRegFullName.Size = new Size(282, 35);
            txtRegFullName.TabIndex = 0;
            txtRegFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(219, 426);
            txtRegUsername.Margin = new Padding(3, 4, 3, 4);
            txtRegUsername.Multiline = true;
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(260, 39);
            txtRegUsername.TabIndex = 1;
            // 
            // txtRegContact
            // 
            txtRegContact.Location = new Point(220, 169);
            txtRegContact.Margin = new Padding(3, 4, 3, 4);
            txtRegContact.Multiline = true;
            txtRegContact.Name = "txtRegContact";
            txtRegContact.Size = new Size(282, 32);
            txtRegContact.TabIndex = 2;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(219, 497);
            txtRegPassword.Margin = new Padding(3, 4, 3, 4);
            txtRegPassword.Multiline = true;
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.Size = new Size(260, 39);
            txtRegPassword.TabIndex = 3;
            // 
            // btnRegisterSubmit
            // 
            btnRegisterSubmit.BackColor = Color.FromArgb(0, 119, 182);
            btnRegisterSubmit.FlatStyle = FlatStyle.Flat;
            btnRegisterSubmit.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterSubmit.ForeColor = Color.White;
            btnRegisterSubmit.Location = new Point(220, 557);
            btnRegisterSubmit.Margin = new Padding(3, 4, 3, 4);
            btnRegisterSubmit.Name = "btnRegisterSubmit";
            btnRegisterSubmit.Size = new Size(332, 46);
            btnRegisterSubmit.TabIndex = 5;
            btnRegisterSubmit.Text = "REGISTER";
            btnRegisterSubmit.UseVisualStyleBackColor = false;
            btnRegisterSubmit.Click += btnRegisterSubmit_Click;
            // 
            // lnkBackToLogin
            // 
            lnkBackToLogin.AutoSize = true;
            lnkBackToLogin.BackColor = Color.Transparent;
            lnkBackToLogin.Location = new Point(294, 616);
            lnkBackToLogin.Name = "lnkBackToLogin";
            lnkBackToLogin.Size = new Size(219, 20);
            lnkBackToLogin.TabIndex = 6;
            lnkBackToLogin.TabStop = true;
            lnkBackToLogin.Text = "Already have an account? Login";
            lnkBackToLogin.LinkClicked += lnkBackToLogin_LinkClicked;
            // 
            // registrationPanel
            // 
            registrationPanel.BackColor = Color.FromArgb(150, 255, 255, 255);
            registrationPanel.Controls.Add(comboBox1);
            registrationPanel.Controls.Add(label9);
            registrationPanel.Controls.Add(label8);
            registrationPanel.Controls.Add(txtRegEmail);
            registrationPanel.Controls.Add(txtRegCountry);
            registrationPanel.Controls.Add(label7);
            registrationPanel.Controls.Add(label6);
            registrationPanel.Controls.Add(label5);
            registrationPanel.Controls.Add(label4);
            registrationPanel.Controls.Add(label3);
            registrationPanel.Controls.Add(label1);
            registrationPanel.Controls.Add(txtRegUsername);
            registrationPanel.Controls.Add(txtRegFullName);
            registrationPanel.Controls.Add(lnkBackToLogin);
            registrationPanel.Controls.Add(txtRegContact);
            registrationPanel.Controls.Add(btnRegisterSubmit);
            registrationPanel.Controls.Add(txtRegPassword);
            registrationPanel.Location = new Point(138, 64);
            registrationPanel.Margin = new Padding(3, 4, 3, 4);
            registrationPanel.Name = "registrationPanel";
            registrationPanel.Size = new Size(752, 651);
            registrationPanel.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(220, 366);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(46, 370);
            label9.Name = "label9";
            label9.Size = new Size(96, 18);
            label9.TabIndex = 15;
            label9.Text = "SKILL LEVEL";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(46, 305);
            label8.Name = "label8";
            label8.Size = new Size(51, 18);
            label8.TabIndex = 14;
            label8.Text = "EMAIL";
            // 
            // txtRegEmail
            // 
            txtRegEmail.Location = new Point(219, 301);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.Size = new Size(374, 27);
            txtRegEmail.TabIndex = 13;
            // 
            // txtRegCountry
            // 
            txtRegCountry.Location = new Point(220, 237);
            txtRegCountry.Name = "txtRegCountry";
            txtRegCountry.Size = new Size(219, 27);
            txtRegCountry.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(46, 241);
            label7.Name = "label7";
            label7.Size = new Size(82, 18);
            label7.TabIndex = 11;
            label7.Text = "COUNTRY";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(46, 501);
            label6.Name = "label6";
            label6.Size = new Size(96, 18);
            label6.TabIndex = 10;
            label6.Text = "PASSWORD";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft PhagsPa", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 429);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 9;
            label5.Text = "USERNAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(46, 173);
            label4.Name = "label4";
            label4.Size = new Size(150, 18);
            label4.TabIndex = 8;
            label4.Text = "CONTACT NUMBER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(46, 110);
            label3.Name = "label3";
            label3.Size = new Size(91, 18);
            label3.TabIndex = 7;
            label3.Text = "FULL NAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 24);
            label1.Name = "label1";
            label1.Size = new Size(487, 45);
            label1.TabIndex = 0;
            label1.Text = "Create Your Aquaride Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1061, 802);
            Controls.Add(registrationPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RegisterForm";
            Text = "RegisterForm";
            registrationPanel.ResumeLayout(false);
            registrationPanel.PerformLayout();
            ResumeLayout(false);

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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Label label8;
        private TextBox txtRegEmail;
        private TextBox txtRegCountry;
        private Label label7;
        private ComboBox comboBox1;
        private Label label9;
    }
}