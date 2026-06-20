namespace surf_Board
{
    partial class InstructorCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picInstructor = new PictureBox();
            lblInstructorName = new Label();
            lblExperience = new Label();
            lblStatus = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picInstructor).BeginInit();
            SuspendLayout();
            // 
            // picInstructor
            // 
            picInstructor.Location = new Point(25, 23);
            picInstructor.Name = "picInstructor";
            picInstructor.Size = new Size(180, 130);
            picInstructor.SizeMode = PictureBoxSizeMode.Zoom;
            picInstructor.TabIndex = 0;
            picInstructor.TabStop = false;
            // 
            // lblInstructorName
            // 
            lblInstructorName.AutoSize = true;
            lblInstructorName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstructorName.Location = new Point(34, 178);
            lblInstructorName.Name = "lblInstructorName";
            lblInstructorName.Size = new Size(51, 20);
            lblInstructorName.TabIndex = 1;
            lblInstructorName.Text = "label1";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(34, 208);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(50, 20);
            lblExperience.TabIndex = 2;
            lblExperience.Text = "label2";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(35, 237);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "label3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 206);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // InstructorCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(label1);
            Controls.Add(lblStatus);
            Controls.Add(lblExperience);
            Controls.Add(lblInstructorName);
            Controls.Add(picInstructor);
            Name = "InstructorCard";
            Size = new Size(232, 278);
            ((System.ComponentModel.ISupportInitialize)picInstructor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picInstructor;
        private Label lblInstructorName;
        private Label lblExperience;
        private Label lblStatus;
        private Label label1;
    }
}
