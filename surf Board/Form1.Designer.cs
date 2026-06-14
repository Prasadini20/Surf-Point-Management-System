namespace surf_Board
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtBoardID = new TextBox();
            txtSize = new TextBox();
            txtPrice = new TextBox();
            cmbBoardType = new ComboBox();
            cmbCondition = new ComboBox();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvBoards = new DataGridView();
            cmbSearch = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            groupBox1 = new GroupBox();
            grpDetails = new GroupBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBoards).BeginInit();
            groupBox1.SuspendLayout();
            grpDetails.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(393, 9);
            label1.Name = "label1";
            label1.Size = new Size(396, 38);
            label1.TabIndex = 0;
            label1.Text = "SURFBOARD MANAGEMENT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.WaitCursor;
            label2.Location = new Point(16, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Board ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 101);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Board Type :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 165);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Board Size :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 41);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 4;
            label5.Text = "Condition :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 101);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "Price Per Hour  :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(367, 162);
            label7.Name = "label7";
            label7.Size = new Size(56, 20);
            label7.TabIndex = 6;
            label7.Text = "Status :";
            // 
            // txtBoardID
            // 
            txtBoardID.Location = new Point(120, 38);
            txtBoardID.Name = "txtBoardID";
            txtBoardID.Size = new Size(177, 27);
            txtBoardID.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(120, 162);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(177, 27);
            txtSize.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(476, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(186, 27);
            txtPrice.TabIndex = 9;
            // 
            // cmbBoardType
            // 
            cmbBoardType.FormattingEnabled = true;
            cmbBoardType.Location = new Point(120, 101);
            cmbBoardType.Name = "cmbBoardType";
            cmbBoardType.Size = new Size(177, 28);
            cmbBoardType.TabIndex = 10;
            // 
            // cmbCondition
            // 
            cmbCondition.FormattingEnabled = true;
            cmbCondition.Location = new Point(476, 38);
            cmbCondition.Name = "cmbCondition";
            cmbCondition.Size = new Size(186, 28);
            cmbCondition.TabIndex = 11;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(476, 157);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(186, 28);
            cmbStatus.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SteelBlue;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(171, 341);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 13;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(352, 341);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SteelBlue;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(525, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.SteelBlue;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(695, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dgvBoards
            // 
            dgvBoards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBoards.Location = new Point(92, 421);
            dgvBoards.Name = "dgvBoards";
            dgvBoards.RowHeadersWidth = 51;
            dgvBoards.Size = new Size(805, 337);
            dgvBoards.TabIndex = 17;
            // 
            // cmbSearch
            // 
            cmbSearch.FormattingEnabled = true;
            cmbSearch.Location = new Point(26, 41);
            cmbSearch.Name = "cmbSearch";
            cmbSearch.Size = new Size(163, 28);
            cmbSearch.TabIndex = 20;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(26, 104);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(163, 27);
            txtSearch.TabIndex = 21;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(26, 164);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(163, 29);
            btnSearch.TabIndex = 22;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSearch);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(802, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(218, 236);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Surfboards";
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(label2);
            grpDetails.Controls.Add(txtBoardID);
            grpDetails.Controls.Add(label3);
            grpDetails.Controls.Add(cmbBoardType);
            grpDetails.Controls.Add(label4);
            grpDetails.Controls.Add(txtSize);
            grpDetails.Controls.Add(label5);
            grpDetails.Controls.Add(cmbStatus);
            grpDetails.Controls.Add(cmbCondition);
            grpDetails.Controls.Add(label7);
            grpDetails.Controls.Add(txtPrice);
            grpDetails.Controls.Add(label6);
            grpDetails.Location = new Point(76, 56);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(693, 236);
            grpDetails.TabIndex = 24;
            grpDetails.TabStop = false;
            grpDetails.Text = "Surfboard Details";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.SteelBlue;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(854, 341);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 25;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1122, 770);
            Controls.Add(btnRefresh);
            Controls.Add(grpDetails);
            Controls.Add(groupBox1);
            Controls.Add(dgvBoards);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBoards).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtBoardID;
        private TextBox txtSize;
        private TextBox txtPrice;
        private ComboBox cmbBoardType;
        private ComboBox cmbCondition;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvBoards;
        private ComboBox cmbSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private GroupBox groupBox1;
        private GroupBox grpDetails;
        private Button btnRefresh;
    }
}
