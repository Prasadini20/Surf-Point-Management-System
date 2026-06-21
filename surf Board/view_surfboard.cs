using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class view_surfboard : Form
    {
        public view_surfboard()
        {
            InitializeComponent();



        }



        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Dashboard dashboard = new Customer_Dashboard();

            dashboard.Show();

            this.Close();
        }

        private void view_surfboard_Paint(object sender, PaintEventArgs e)
        {
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(43, 181, 212),
                Color.White,
                90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
