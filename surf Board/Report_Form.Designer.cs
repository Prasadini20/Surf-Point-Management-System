namespace surf_Board
{
    partial class Report_Form
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
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            label3 = new Label();
            cmbReportType = new ComboBox();
            btnGenerateReport = new Button();
            dgvReports = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReports).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 42);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "From  :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 89);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "To     :";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(191, 42);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(250, 27);
            dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(188, 78);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(250, 27);
            dtpTo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 148);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 4;
            label3.Text = "Report Type :";
            // 
            // cmbReportType
            // 
            cmbReportType.FormattingEnabled = true;
            cmbReportType.Items.AddRange(new object[] { "Booking Report", "Payment Report", "Customer Report" });
            cmbReportType.Location = new Point(226, 150);
            cmbReportType.Name = "cmbReportType";
            cmbReportType.Size = new Size(151, 28);
            cmbReportType.TabIndex = 5;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = Color.SteelBlue;
            btnGenerateReport.Location = new Point(144, 215);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(205, 29);
            btnGenerateReport.TabIndex = 6;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dgvReports
            // 
            dgvReports.AllowUserToAddRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.Location = new Point(49, 296);
            dgvReports.Name = "dgvReports";
            dgvReports.ReadOnly = true;
            dgvReports.RowHeadersWidth = 51;
            dgvReports.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReports.Size = new Size(577, 188);
            dgvReports.TabIndex = 7;
            // 
            // Report_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvReports);
            Controls.Add(btnGenerateReport);
            Controls.Add(cmbReportType);
            Controls.Add(label3);
            Controls.Add(dtpTo);
            Controls.Add(dtpFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Report_Form";
            Text = "Report_Form";
            Load += Report_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReports).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label3;
        private ComboBox cmbReportType;
        private Button btnGenerateReport;
        private DataGridView dgvReports;
    }
}