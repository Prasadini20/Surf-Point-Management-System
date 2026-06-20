namespace surf_Board
{
    partial class InstructorForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtInstructorID = new TextBox();
            txtName = new TextBox();
            txtContact = new TextBox();
            txtExperience = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            btnClear = new Button();
            dgvInstructor = new DataGridView();
            colInstructoeID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colContact = new DataGridViewTextBoxColumn();
            colExperience = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            label6 = new Label();
            cmbStatus = new ComboBox();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvInstructor).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(95, 116);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Instructor ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 178);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 251);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(496, 123);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 3;
            label4.Text = "Experience Years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(496, 196);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 4;
            label5.Text = "Availability Status";
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new Point(253, 116);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(171, 27);
            txtInstructorID.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(253, 178);
            txtName.Name = "txtName";
            txtName.Size = new Size(171, 27);
            txtName.TabIndex = 6;
            txtName.TextChanged += txtInstructorName_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(253, 251);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(171, 27);
            txtContact.TabIndex = 7;
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(698, 123);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(173, 27);
            txtExperience.TabIndex = 8;
            txtExperience.TextChanged += txtExperience_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(100, 376);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(289, 376);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(470, 376);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SteelBlue;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(652, 376);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(826, 376);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvInstructor
            // 
            dgvInstructor.BackgroundColor = Color.White;
            dgvInstructor.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInstructor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructor.Columns.AddRange(new DataGridViewColumn[] { colInstructoeID, colName, colContact, colExperience, colStatus });
            dgvInstructor.Location = new Point(155, 457);
            dgvInstructor.Name = "dgvInstructor";
            dgvInstructor.RowHeadersWidth = 51;
            dgvInstructor.Size = new Size(674, 188);
            dgvInstructor.TabIndex = 15;
            dgvInstructor.CellClick += dgvInstructor_CellContentClick;
            // 
            // colInstructoeID
            // 
            colInstructoeID.DataPropertyName = "InstructorID";
            colInstructoeID.HeaderText = "Instructor ID";
            colInstructoeID.MinimumWidth = 6;
            colInstructoeID.Name = "colInstructoeID";
            colInstructoeID.Width = 125;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colContact
            // 
            colContact.DataPropertyName = "ContactNumber";
            colContact.HeaderText = "Contact Number";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.Width = 125;
            // 
            // colExperience
            // 
            colExperience.DataPropertyName = "ExperienceYears";
            colExperience.HeaderText = "Experience Years";
            colExperience.MinimumWidth = 6;
            colExperience.Name = "colExperience";
            colExperience.Width = 125;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "AvailabilityStatus";
            colStatus.HeaderText = "Availability Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(341, -1);
            label6.Name = "label6";
            label6.Size = new Size(330, 31);
            label6.TabIndex = 16;
            label6.Text = "Instructor Management Form";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Busy", "On Leave" });
            cmbStatus.Location = new Point(698, 193);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(173, 28);
            cmbStatus.TabIndex = 17;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(982, 28);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.BackColor = Color.Transparent;
            exitToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(49, 24);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(982, 753);
            Controls.Add(cmbStatus);
            Controls.Add(label6);
            Controls.Add(dgvInstructor);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtExperience);
            Controls.Add(txtContact);
            Controls.Add(txtName);
            Controls.Add(txtInstructorID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Management";
            Load += InstructorForm_Load;
            Paint += InstructorForm_Paint;
            ((System.ComponentModel.ISupportInitialize)dgvInstructor).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtInstructorID;
        private TextBox txtName;
        private TextBox txtContact;
        private TextBox txtExperience;
        private TextBox txtStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView dgvInstructor;
        private DataGridViewTextBoxColumn colInstructoeID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colContact;
        private DataGridViewTextBoxColumn colExperience;
        private DataGridViewTextBoxColumn colStatus;
        private Label label6;
        private ComboBox cmbStatus;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}