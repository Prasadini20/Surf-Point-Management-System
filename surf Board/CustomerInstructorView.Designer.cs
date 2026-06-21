namespace surf_Board
{
    partial class CustomerInstructorView
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
            flpInstructors = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpInstructors
            // 
            flpInstructors.AutoScroll = true;
            flpInstructors.Dock = DockStyle.Fill;
            flpInstructors.Location = new Point(0, 0);
            flpInstructors.Name = "flpInstructors";
            flpInstructors.Size = new Size(800, 450);
            flpInstructors.TabIndex = 0;
            flpInstructors.Paint += flpInstructors_Paint_1;
            // 
            // CustomerInstructorView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpInstructors);
            Name = "CustomerInstructorView";
            Text = "CustomerInstructorView";
            Load += CustomerInstructorView_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpInstructors;
    }
}