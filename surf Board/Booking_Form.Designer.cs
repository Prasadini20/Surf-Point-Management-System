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
            lblCustomerIDLabel = new Label();
            lblSurfboard = new Label();
            lblBookingDate = new Label();
            cmbSurfboardType = new ComboBox();
            dtpBookingDate = new DateTimePicker();
            btnSubmit = new Button();
            btnClear = new Button();
            dgvBookings = new DataGridView();
            label1 = new Label();
            lblBookingID = new Label();
            txtBookingID = new TextBox();
            lblCustomerID = new Label();
            lblTotal = new Label();
            txtTotalAmount = new TextBox();
            label2 = new Label();
            cmbService = new ComboBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newBookingToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            managementToolStripMenuItem = new ToolStripMenuItem();
            sessionsToolStripMenuItem = new ToolStripMenuItem();
            surfboardsToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCustomerIDLabel
            // 
            lblCustomerIDLabel.AutoSize = true;
            lblCustomerIDLabel.Location = new Point(690, 160);
            lblCustomerIDLabel.Name = "lblCustomerIDLabel";
            lblCustomerIDLabel.Size = new Size(134, 20);
            lblCustomerIDLabel.TabIndex = 1;
            lblCustomerIDLabel.Text = "Customer ID          :";
            // 
            // lblSurfboard
            // 
            lblSurfboard.AutoSize = true;
            lblSurfboard.Location = new Point(43, 141);
            lblSurfboard.Name = "lblSurfboard";
            lblSurfboard.Size = new Size(133, 20);
            lblSurfboard.TabIndex = 2;
            lblSurfboard.Text = "Surfboard Type     :";
            // 
            // lblBookingDate
            // 
            lblBookingDate.AutoSize = true;
            lblBookingDate.Location = new Point(43, 199);
            lblBookingDate.Name = "lblBookingDate";
            lblBookingDate.Size = new Size(132, 20);
            lblBookingDate.TabIndex = 3;
            lblBookingDate.Text = "Date                      :";
            // 
            // cmbSurfboardType
            // 
            cmbSurfboardType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSurfboardType.FormattingEnabled = true;
            cmbSurfboardType.Items.AddRange(new object[] { "Shortboard", "Longboard", "Fish", "Funboard", "HybridSoft Top" });
            cmbSurfboardType.Location = new Point(217, 141);
            cmbSurfboardType.Name = "cmbSurfboardType";
            cmbSurfboardType.Size = new Size(250, 28);
            cmbSurfboardType.TabIndex = 7;
            cmbSurfboardType.SelectedIndexChanged += CalculateTotal;
            // 
            // dtpBookingDate
            // 
            dtpBookingDate.Format = DateTimePickerFormat.Short;
            dtpBookingDate.Location = new Point(217, 199);
            dtpBookingDate.Name = "dtpBookingDate";
            dtpBookingDate.Size = new Size(250, 27);
            dtpBookingDate.TabIndex = 8;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SteelBlue;
            btnSubmit.Location = new Point(181, 356);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 10;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Location = new Point(442, 356);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(44, 391);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.Size = new Size(740, 188);
            dgvBookings.TabIndex = 14;
            dgvBookings.CellContentClick += dgvBookings_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(572, 41);
            label1.TabIndex = 15;
            label1.Text = "SURFBOARD BOOKING MANAGEMENT";
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Location = new Point(690, 111);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(94, 20);
            lblBookingID.TabIndex = 17;
            lblBookingID.Text = "Booking ID  :";
            // 
            // txtBookingID
            // 
            txtBookingID.Location = new Point(913, 108);
            txtBookingID.Name = "txtBookingID";
            txtBookingID.ReadOnly = true;
            txtBookingID.Size = new Size(125, 27);
            txtBookingID.TabIndex = 18;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(913, 160);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(0, 20);
            lblCustomerID.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(690, 216);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(110, 20);
            lblTotal.TabIndex = 20;
            lblTotal.Text = "Total Amount  :";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(913, 213);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(125, 27);
            txtTotalAmount.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 85);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 22;
            label2.Text = "Service";
            // 
            // cmbService
            // 
            cmbService.FormattingEnabled = true;
            cmbService.Items.AddRange(new object[] { "Private surf lesson beginners (1 person) - 6,000 LKR  (75 min)", "Private surf lesson for couple beginners (2 persons) - 9,000 LKR  (75 min)", "Private surf lesson intermediate (1 person) - 7,500 LKR  (90 min)", "SURF GUIDE (any spot down south) - 9,000 LKR  (90 min)" });
            cmbService.Location = new Point(106, 82);
            cmbService.Name = "cmbService";
            cmbService.Size = new Size(203, 28);
            cmbService.TabIndex = 23;
            cmbService.SelectedIndexChanged += CalculateTotal;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, managementToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1150, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newBookingToolStripMenuItem, dashboardToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // newBookingToolStripMenuItem
            // 
            newBookingToolStripMenuItem.Name = "newBookingToolStripMenuItem";
            newBookingToolStripMenuItem.Size = new Size(181, 26);
            newBookingToolStripMenuItem.Text = "New Booking";
            newBookingToolStripMenuItem.Click += newBookingToolStripMenuItem_Click;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(181, 26);
            dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(181, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // managementToolStripMenuItem
            // 
            managementToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sessionsToolStripMenuItem, surfboardsToolStripMenuItem });
            managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            managementToolStripMenuItem.Size = new Size(55, 24);
            managementToolStripMenuItem.Text = "View";
            // 
            // sessionsToolStripMenuItem
            // 
            sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            sessionsToolStripMenuItem.Size = new Size(164, 26);
            sessionsToolStripMenuItem.Text = "Sessions";
            // 
            // surfboardsToolStripMenuItem
            // 
            surfboardsToolStripMenuItem.Name = "surfboardsToolStripMenuItem";
            surfboardsToolStripMenuItem.Size = new Size(164, 26);
            surfboardsToolStripMenuItem.Text = "Surfboards";
            surfboardsToolStripMenuItem.Click += surfboardsToolStripMenuItem_Click;
            // 
            // Booking_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1150, 609);
            Controls.Add(cmbService);
            Controls.Add(label2);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblTotal);
            Controls.Add(lblCustomerID);
            Controls.Add(txtBookingID);
            Controls.Add(lblBookingID);
            Controls.Add(label1);
            Controls.Add(dgvBookings);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(dtpBookingDate);
            Controls.Add(cmbSurfboardType);
            Controls.Add(lblBookingDate);
            Controls.Add(lblSurfboard);
            Controls.Add(lblCustomerIDLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Booking_Form";
            Text = "Booking_Form";
            Load += Booking_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCustomerIDLabel;
        private Label lblSurfboard;
        private Label lblBookingDate;
        private ComboBox cmbSurfboardType;
        private DateTimePicker dtpBookingDate;
        private Button btnSubmit;
        private Button btnClear;
        private DataGridView dgvBookings;
        private Label label1;
        private Label lblBookingID;
        private TextBox txtBookingID;
        private Label lblCustomerID;
        private Label lblTotal;
        private TextBox txtTotalAmount;
        private Label label2;
        private ComboBox cmbService;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newBookingToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem managementToolStripMenuItem;
        private ToolStripMenuItem sessionsToolStripMenuItem;
        private ToolStripMenuItem surfboardsToolStripMenuItem;
    }
}