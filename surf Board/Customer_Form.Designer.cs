namespace surf_Board
{
    partial class Customer_Form
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
            lblCustomerID = new Label();
            lblName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblCountry = new Label();
            lblSkill = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            dgvCustomer = new DataGridView();
            colCustomerID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colCountry = new DataGridViewTextBoxColumn();
            colSkill = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtCountry = new TextBox();
            txtCustomerID = new TextBox();
            txtSkill = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(110, 61);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(91, 20);
            lblCustomerID.TabIndex = 0;
            lblCustomerID.Text = "Customer ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(110, 110);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(110, 155);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(108, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(110, 202);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(110, 255);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(60, 20);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country";
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(110, 309);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(74, 20);
            lblSkill.TabIndex = 5;
            lblSkill.Text = "Skill Level";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(38, 413);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(197, 413);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(354, 413);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(517, 413);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(681, 413);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvCustomer
            // 
            dgvCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomer.Columns.AddRange(new DataGridViewColumn[] { colCustomerID, colName, colPhone, colEmail, colCountry, colSkill });
            dgvCustomer.Location = new Point(38, 467);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidth = 51;
            dgvCustomer.Size = new Size(801, 274);
            dgvCustomer.TabIndex = 11;
            dgvCustomer.CellClick += dgvCustomer_CellClick;
            // 
            // colCustomerID
            // 
            colCustomerID.HeaderText = "Customer ID";
            colCustomerID.MinimumWidth = 6;
            colCustomerID.Name = "colCustomerID";
            colCustomerID.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colPhone
            // 
            colPhone.HeaderText = "Phone Number";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.Width = 125;
            // 
            // colEmail
            // 
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.Width = 125;
            // 
            // colCountry
            // 
            colCountry.HeaderText = "Country";
            colCountry.MinimumWidth = 6;
            colCountry.Name = "colCountry";
            colCountry.Width = 125;
            // 
            // colSkill
            // 
            colSkill.HeaderText = "Skill Level";
            colSkill.MinimumWidth = 6;
            colSkill.Name = "colSkill";
            colSkill.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, -2);
            label1.Name = "label1";
            label1.Size = new Size(379, 31);
            label1.TabIndex = 12;
            label1.Text = "CUSTOMER MANAGEMENT FORM";
            // 
            // txtName
            // 
            txtName.Location = new Point(266, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(266, 27);
            txtName.TabIndex = 13;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(266, 152);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(266, 27);
            txtPhone.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(266, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(266, 255);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(266, 27);
            txtCountry.TabIndex = 16;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(266, 61);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(266, 27);
            txtCustomerID.TabIndex = 18;
            // 
            // txtSkill
            // 
            txtSkill.Location = new Point(266, 302);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(266, 27);
            txtSkill.TabIndex = 19;
            // 
            // Customer_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(982, 753);
            Controls.Add(txtSkill);
            Controls.Add(txtCustomerID);
            Controls.Add(txtCountry);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dgvCustomer);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblSkill);
            Controls.Add(lblCountry);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Controls.Add(lblCustomerID);
            Name = "Customer_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Management";
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCustomerID;
        private Label lblName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblCountry;
        private Label lblSkill;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView dgvCustomer;
        private Label label1;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtCountry;
        private TextBox txtCustomerID;
        private TextBox txtSkill;
        private DataGridViewTextBoxColumn colCustomerID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colCountry;
        private DataGridViewTextBoxColumn colSkill;
    }
}