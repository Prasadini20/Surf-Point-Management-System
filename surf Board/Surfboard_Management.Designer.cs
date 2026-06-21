namespace surf_Board
{
    partial class Surfboard_Management
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
            cmbStatus = new ComboBox();
            cmbCondition = new ComboBox();
            cmbBoardType = new ComboBox();
            txtPrice = new TextBox();
            textBoardID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvSurfboards = new DataGridView();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            exitToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSurfboards).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbStatus);
            groupBox1.Controls.Add(cmbCondition);
            groupBox1.Controls.Add(cmbBoardType);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(textBoardID);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(26, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(798, 269);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Surfbaord Details :";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(543, 194);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(151, 28);
            cmbStatus.TabIndex = 14;
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(543, 40);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(151, 28);
            cmbCondition.TabIndex = 13;
            // 
            // cmbBoardType
            // 
            cmbBoardType.FormattingEnabled = true;
            cmbBoardType.Location = new Point(169, 124);
            cmbBoardType.Name = "cmbBoardType";
            cmbBoardType.Size = new Size(151, 28);
            cmbBoardType.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(543, 117);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 10;
            // 
            // textBoardID
            // 
            textBoardID.Location = new Point(169, 51);
            textBoardID.Name = "textBoardID";
            textBoardID.Size = new Size(151, 27);
            textBoardID.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 202);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 7;
            label6.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 124);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Price (Rs) :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 48);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Condition :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 127);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Board Type :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.CausesValidation = false;
            label1.Location = new Point(19, 51);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Board ID :";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.SteelBlue;
            btnAddNew.Location = new Point(38, 405);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Location = new Point(208, 405);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.Location = new Point(387, 405);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.Location = new Point(579, 405);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvSurfboards
            // 
            dgvSurfboards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSurfboards.Location = new Point(26, 468);
            dgvSurfboards.Name = "dgvSurfboards";
            dgvSurfboards.RowHeadersWidth = 51;
            dgvSurfboards.Size = new Size(787, 259);
            dgvSurfboards.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.SteelBlue;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(372, 0);
            label7.Name = "label7";
            label7.Size = new Size(357, 41);
            label7.TabIndex = 7;
            label7.Text = "Surfboard Management";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(995, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Surfboard_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(995, 796);
            Controls.Add(label7);
            Controls.Add(dgvSurfboards);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Surfboard_Management";
            Text = "Surfboard_Management";
            FormClosing += Surfboard_Management_FormClosing;
            Load += Surfboard_Management_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSurfboards).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbStatus;
        private ComboBox cmbCondition;
        private ComboBox cmbBoardType;
        private TextBox txtPrice;
        private TextBox textBoardID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvSurfboards;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}