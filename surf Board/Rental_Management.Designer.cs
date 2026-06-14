namespace surf_Board
{
    partial class Rental_Management
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
            groupBox1 = new GroupBox();
            txtHours = new TextBox();
            dtpReturnDate = new DateTimePicker();
            dtpIssueDate = new DateTimePicker();
            cmbSurfBoard = new ComboBox();
            cmbCustomer = new ComboBox();
            txtRentalID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtTotalAmount = new TextBox();
            txtPricePerHour = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            btnCalculate = new Button();
            btnReturn = new Button();
            btnIssue = new Button();
            groupBox4 = new GroupBox();
            dgvRentalHistory = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRentalHistory).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtHours);
            groupBox1.Controls.Add(dtpReturnDate);
            groupBox1.Controls.Add(dtpIssueDate);
            groupBox1.Controls.Add(cmbSurfBoard);
            groupBox1.Controls.Add(cmbCustomer);
            groupBox1.Controls.Add(txtRentalID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(761, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rental Information";
            // 
            // txtHours
            // 
            txtHours.Location = new Point(493, 173);
            txtHours.Name = "txtHours";
            txtHours.Size = new Size(250, 27);
            txtHours.TabIndex = 11;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Location = new Point(493, 109);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(250, 27);
            dtpReturnDate.TabIndex = 10;
            // 
            // dtpIssueDate
            // 
            dtpIssueDate.Location = new Point(493, 43);
            dtpIssueDate.Name = "dtpIssueDate";
            dtpIssueDate.Size = new Size(250, 27);
            dtpIssueDate.TabIndex = 9;
            // 
            // cmbSurfBoard
            // 
            cmbSurfBoard.FormattingEnabled = true;
            cmbSurfBoard.Location = new Point(123, 170);
            cmbSurfBoard.Name = "cmbSurfBoard";
            cmbSurfBoard.Size = new Size(203, 28);
            cmbSurfBoard.TabIndex = 8;
            cmbSurfBoard.SelectedIndexChanged += cmbSurfBoard_SelectedIndexChanged;
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(123, 109);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(203, 28);
            cmbCustomer.TabIndex = 7;
            // 
            // txtRentalID
            // 
            txtRentalID.Location = new Point(123, 45);
            txtRentalID.Name = "txtRentalID";
            txtRentalID.Size = new Size(203, 27);
            txtRentalID.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 173);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 5;
            label7.Text = "Hours :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(381, 114);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 4;
            label6.Text = "Return Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(381, 48);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 3;
            label5.Text = "Issue Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 173);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 2;
            label4.Text = "Surfboard :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 110);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 1;
            label3.Text = "Customer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 48);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 0;
            label2.Text = "Rental ID :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotalAmount);
            groupBox2.Controls.Add(txtPricePerHour);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(794, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 238);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Payment Information";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(204, 107);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(154, 27);
            txtTotalAmount.TabIndex = 3;
            // 
            // txtPricePerHour
            // 
            txtPricePerHour.Location = new Point(204, 45);
            txtPricePerHour.Name = "txtPricePerHour";
            txtPricePerHour.Size = new Size(154, 27);
            txtPricePerHour.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 114);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 1;
            label9.Text = "Total Amount(LKR) :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(37, 50);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 0;
            label8.Text = "Price per Hour(LKR) :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(572, 39);
            label1.Name = "label1";
            label1.Size = new Size(421, 38);
            label1.TabIndex = 2;
            label1.Text = "RENTAL MANAGEMENT FORM";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnCalculate);
            groupBox3.Controls.Add(btnReturn);
            groupBox3.Controls.Add(btnIssue);
            groupBox3.Location = new Point(1189, 124);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(166, 229);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Actions";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.SteelBlue;
            btnCalculate.Location = new Point(29, 167);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 2;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.SteelBlue;
            btnReturn.Location = new Point(29, 100);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 29);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Return Board";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // btnIssue
            // 
            btnIssue.BackColor = Color.SteelBlue;
            btnIssue.Location = new Point(29, 40);
            btnIssue.Name = "btnIssue";
            btnIssue.Size = new Size(94, 29);
            btnIssue.TabIndex = 0;
            btnIssue.Text = "Issue Board";
            btnIssue.UseVisualStyleBackColor = false;
            btnIssue.Click += btnIssueBoard_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvRentalHistory);
            groupBox4.Location = new Point(30, 388);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1205, 306);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rental History";
            // 
            // dgvRentalHistory
            // 
            dgvRentalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalHistory.Location = new Point(19, 26);
            dgvRentalHistory.Name = "dgvRentalHistory";
            dgvRentalHistory.RowHeadersWidth = 51;
            dgvRentalHistory.Size = new Size(1154, 274);
            dgvRentalHistory.TabIndex = 0;
            // 
            // Rental_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1461, 706);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Rental_Management";
            Text = "Rental_Management";
            Load += Rental_Management_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRentalHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpReturnDate;
        private DateTimePicker dtpIssueDate;
        private ComboBox cmbSurfBoard;
        private ComboBox cmbCustomer;
        private TextBox txtRentalID;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtHours;
        private TextBox txtTotalAmount;
        private TextBox txtPricePerHour;
        private Label label9;
        private Label label8;
        private GroupBox groupBox3;
        private Button btnCalculate;
        private Button btnReturn;
        private Button btnIssue;
        private GroupBox groupBox4;
        private DataGridView dgvRentalHistory;
    }
}