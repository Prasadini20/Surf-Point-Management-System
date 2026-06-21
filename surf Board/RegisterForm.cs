using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            // 1. Force the panel to have a completely transparent default background
            registrationPanel.BackColor = Color.Transparent;

            // 2. Set the Form as the direct structural parent of the panel
            registrationPanel.Parent = this;
            txtRegUsername.Focus();
        }

        private void registrationPanel_Paint(object sender, PaintEventArgs e)
        {
            // 1. Setup smooth drawing tools
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // 2. Create the rounded path
            int borderRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // We cast the sender to a Panel to get the size safely without errors
            Panel panel = sender as Panel;

            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
            path.AddArc(panel.Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
            path.AddArc(panel.Width - borderRadius - 1, panel.Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
            path.AddArc(0, panel.Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
            path.CloseAllFigures();

            // 3. Apply the region shape so controls inside are clipped to the curves
            panel.Region = new Region(path);

            // 4. Draw the "Mist" semi-transparent white card background
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(180, 255, 255, 255)))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtRegPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {

        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
        }

        private void txtRegFullName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
