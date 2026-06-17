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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtInstructorID = new TextBox();
            txtInstructorName = new TextBox();
            txtContact = new TextBox();
            txtExperience = new TextBox();
            txtStatus = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvInstructor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 95);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Instructor ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(97, 145);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(97, 195);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 2;
            label3.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(97, 238);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 3;
            label4.Text = "Experience Years";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(97, 295);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 4;
            label5.Text = "Availability Status";
            // 
            // txtInstructorID
            // 
            txtInstructorID.Location = new Point(253, 95);
            txtInstructorID.Name = "txtInstructorID";
            txtInstructorID.Size = new Size(125, 27);
            txtInstructorID.TabIndex = 5;
            // 
            // txtInstructorName
            // 
            txtInstructorName.Location = new Point(253, 142);
            txtInstructorName.Name = "txtInstructorName";
            txtInstructorName.Size = new Size(125, 27);
            txtInstructorName.TabIndex = 6;
            txtInstructorName.TextChanged += txtInstructorName_TextChanged;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(253, 188);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(125, 27);
            txtContact.TabIndex = 7;
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(253, 238);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(125, 27);
            txtExperience.TabIndex = 8;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(253, 288);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(125, 27);
            txtStatus.TabIndex = 9;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(52, 425);
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
            btnUpdate.Location = new Point(234, 425);
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
            btnDelete.Location = new Point(398, 425);
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
            btnSearch.Location = new Point(577, 425);
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
            btnClear.Location = new Point(752, 425);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvInstructor
            // 
            dgvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInstructor.Columns.AddRange(new DataGridViewColumn[] { colInstructoeID, colName, colContact, colExperience, colStatus });
            dgvInstructor.Location = new Point(68, 514);
            dgvInstructor.Name = "dgvInstructor";
            dgvInstructor.RowHeadersWidth = 51;
            dgvInstructor.Size = new Size(674, 188);
            dgvInstructor.TabIndex = 15;
            dgvInstructor.CellClick += dgvInstructor_CellContentClick;
            // 
            // colInstructoeID
            // 
            colInstructoeID.HeaderText = "Instructor ID";
            colInstructoeID.MinimumWidth = 6;
            colInstructoeID.Name = "colInstructoeID";
            colInstructoeID.Width = 125;
            // 
            // colName
            // 
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.Width = 125;
            // 
            // colContact
            // 
            colContact.HeaderText = "Contact Number";
            colContact.MinimumWidth = 6;
            colContact.Name = "colContact";
            colContact.Width = 125;
            // 
            // colExperience
            // 
            colExperience.HeaderText = "Experience Years";
            colExperience.MinimumWidth = 6;
            colExperience.Name = "colExperience";
            colExperience.Width = 125;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Availability Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(341, -1);
            label6.Name = "label6";
            label6.Size = new Size(330, 31);
            label6.TabIndex = 16;
            label6.Text = "Instructor Management Form";
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(982, 753);
            Controls.Add(label6);
            Controls.Add(dgvInstructor);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtStatus);
            Controls.Add(txtExperience);
            Controls.Add(txtContact);
            Controls.Add(txtInstructorName);
            Controls.Add(txtInstructorID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Instructor Management";
            Load += InstructorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInstructor).EndInit();
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
        private TextBox txtInstructorName;
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
    }
}