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
            lblTitle = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 92);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Booking ID       :";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(390, 180);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(148, 27);
            txtAmount.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 180);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount              :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 277);
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
            cmbMethod.Location = new Point(387, 269);
            cmbMethod.Name = "cmbMethod";
            cmbMethod.Size = new Size(151, 28);
            cmbMethod.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 369);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 6;
            label4.Text = "Date               :";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(387, 364);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(151, 27);
            dtpDate.TabIndex = 7;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.SteelBlue;
            btnPay.Location = new Point(248, 482);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(94, 29);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Location = new Point(410, 482);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(202, -2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(385, 41);
            lblTitle.TabIndex = 11;
            lblTitle.Text = "PAYMENT MANAGEMENT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 92);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 12;
            label5.Click += label5_Click;
            // 
            // Payment_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 675);
            Controls.Add(label5);
            Controls.Add(lblTitle);
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
            Paint += Payment_Form_Paint;
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
        private Label lblTitle;
        private Label label5;
    }
}