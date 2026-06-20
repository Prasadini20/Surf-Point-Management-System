namespace surf_Board
{
    partial class Payment_Form
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
            txtAmount = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbMethod = new ComboBox();
            label4 = new Label();
            dtpDate = new DateTimePicker();
            btnPay = new Button();
            btnClear = new Button();
            dgvPayments = new DataGridView();
            lblTitle = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 82);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Booking ID       :";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(228, 139);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 142);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount              :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 212);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 4;
            label3.Text = "Payment Method :";
            // 
            // cmbMethod
            // 
            cmbMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMethod.FormattingEnabled = true;
            cmbMethod.Items.AddRange(new object[] { "Cash", "Card", "Online" });
            cmbMethod.Location = new Point(239, 206);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(151, 28);
            cmbMethod.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 258);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Date               :";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(237, 258);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(128, 27);
            dtpDate.TabIndex = 7;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.SteelBlue;
            btnPay.Location = new Point(56, 322);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Location = new Point(239, 322);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvPayments
            // 
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.Location = new Point(39, 390);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.Size = new Size(644, 188);
            dgvPayments.TabIndex = 10;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(188, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(385, 41);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "PAYMENT MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(232, 83);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 12;
            label5.Text = "label5";
            label5.Click += label5_Click;
            // 
            // Payment_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 524);
            Controls.Add(label5);
            Controls.Add(lblTitle);
            Controls.Add(dgvPayments);
            Controls.Add(btnClear);
            Controls.Add(btnPay);
            Controls.Add(dtpDate);
            Controls.Add(label4);
            Controls.Add(cmbMethod);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAmount);
            Controls.Add(label1);
            Name = "Payment_Form";
            Text = "Payment_Form";
            Load += Payment_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Label label2;
        private Label label3;
        private ComboBox cmbMethod;
        private Label label4;
        private DateTimePicker dtpDate;
        private Button btnPay;
        private Button btnClear;
        private DataGridView dgvPayments;
        private Label lblTitle;
        private Label label5;
    }
}