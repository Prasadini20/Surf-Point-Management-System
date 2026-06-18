namespace surf_Board
{
    partial class Booking_Form
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
            bookingID = new Label();
            lblCustomerID = new Label();
            lblSurfboardType = new Label();
            lblBookingDate = new Label();
            lblDuration = new Label();
            txtBookingID = new TextBox();
            cmbSurfboardType = new ComboBox();
            dtpBookingDate = new DateTimePicker();
            txtDuration = new NumericUpDown();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvBookings = new DataGridView();
            label1 = new Label();
            cmbCustomerID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)txtDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            SuspendLayout();
            // 
            // bookingID
            // 
            bookingID.AutoSize = true;
            bookingID.Location = new Point(44, 60);
            bookingID.Name = "bookingID";
            bookingID.Size = new Size(134, 20);
            bookingID.TabIndex = 0;
            bookingID.Text = "Booking ID            :";
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(44, 109);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(134, 20);
            lblCustomerID.TabIndex = 1;
            lblCustomerID.Text = "Customer ID          :";
            // 
            // lblSurfboardType
            // 
            lblSurfboardType.AutoSize = true;
            lblSurfboardType.Location = new Point(44, 163);
            lblSurfboardType.Name = "lblSurfboardType";
            lblSurfboardType.Size = new Size(133, 20);
            lblSurfboardType.TabIndex = 2;
            lblSurfboardType.Text = "Surfboard Type     :";
            // 
            // lblBookingDate
            // 
            lblBookingDate.AutoSize = true;
            lblBookingDate.Location = new Point(44, 216);
            lblBookingDate.Name = "lblBookingDate";
            lblBookingDate.Size = new Size(132, 20);
            lblBookingDate.TabIndex = 3;
            lblBookingDate.Text = "Date                      :";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(44, 268);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(133, 20);
            lblDuration.TabIndex = 4;
            lblDuration.Text = "Duration in Hours :";
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(259, 57);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Size = new Size(125, 27);
            txtBookingID.TabIndex = 5;
            // 
            // cmbSurfboardType
            // 
            cmbSurfboardType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSurfboardType.FormattingEnabled = true;
            cmbSurfboardType.Items.AddRange(new object[] { "Standard Board", "Premium Board", "Beginner Foamie", "Performance Shortboard" });
            cmbSurfboardType.Location = new Point(259, 160);
            cmbSurfboardType.Name = "cmbSurfboardType";
            cmbSurfboardType.Size = new Size(151, 28);
            cmbSurfboardType.TabIndex = 7;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Format = DateTimePickerFormat.Short;
            dtpBookingDate.Location = new Point(259, 209);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(250, 27);
            dtpBookingDate.TabIndex = 8;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(259, 266);
            txtDuration.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            txtDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(150, 27);
            txtDuration.TabIndex = 9;
            txtDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.Location = new Point(44, 356);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Location = new Point(219, 356);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Location = new Point(400, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Location = new Point(580, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(44, 421);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.Size = new Size(740, 188);
            dgvBookings.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(150, 9);
            label1.Name = "label1";
            label1.Size = new Size(572, 41);
            label1.TabIndex = 15;
            label1.Text = "SURFBOARD BOOKING MANAGEMENT";
            // 
            // cmbCustomerID
            // 
            cmbCustomerID.FormattingEnabled = true;
            cmbCustomerID.Location = new Point(259, 106);
            cmbCustomerID.Name = "cmbCustomerID";
            cmbCustomerID.Size = new Size(151, 28);
            cmbCustomerID.TabIndex = 16;
            // 
            // Booking_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(925, 559);
            Controls.Add(cmbCustomerID);
            Controls.Add(label1);
            Controls.Add(dgvBookings);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtDuration);
            Controls.Add(dtpBookingDate);
            Controls.Add(cmbSurfboardType);
            Controls.Add(txtBookingID);
            Controls.Add(lblDuration);
            Controls.Add(lblBookingDate);
            Controls.Add(lblSurfboardType);
            Controls.Add(lblCustomerID);
            Controls.Add(bookingID);
            Name = "Booking_Form";
            Text = "Booking_Form";
            Load += Booking_Form_Load;
            ((System.ComponentModel.ISupportInitialize)txtDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookingID;
        private Label lblCustomerID;
        private Label lblSurfboardType;
        private Label lblBookingDate;
        private Label lblDuration;
        private TextBox txtBookingID;
        private ComboBox cmbSurfboardType;
        private DateTimePicker dtpBookingDate;
        private NumericUpDown txtDuration;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvBookings;
        private Label label1;
        private ComboBox cmbCustomerID;
    }
}