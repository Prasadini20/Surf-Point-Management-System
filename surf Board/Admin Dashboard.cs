using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Surfing_Management_System
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void ShortcutCard_Paint(object sender, PaintEventArgs e)
        {

            Panel card = sender as Panel;
            if (card == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Create a soft rounded boundary path
            int radius = 15;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(card.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(card.Width - radius - 1, card.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, card.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();

            card.Region = new Region(path);

            // Determine custom pastel background color metrics based on selected panel component name
            Color bgTint = Color.White;
            Color borderLineColor = Color.LightGray;

            if (card.Name == "pnlCardCust")
            {
                bgTint = Color.FromArgb(242, 247, 255);
                borderLineColor = Color.FromArgb(180, 210, 255);
            }
            else if (card.Name == "pnlCardInst")
            {
                bgTint = Color.FromArgb(242, 253, 242);
                borderLineColor = Color.FromArgb(180, 240, 180);
            }
            else if (card.Name == "pnlCardSurf")
            {
                bgTint = Color.FromArgb(255, 251, 242);
                borderLineColor = Color.FromArgb(255, 220, 180);
            }
            else if (card.Name == "pnlCardRepo")
            {
                bgTint = Color.FromArgb(253, 242, 255);
                borderLineColor = Color.FromArgb(240, 180, 255);
            }

            // Draw the background fill
            using (SolidBrush brush = new SolidBrush(bgTint))
            {
                e.Graphics.FillPath(brush, path);
            }

            // Draw the fine border stroke
            using (Pen borderPen = new Pen(borderLineColor, 1.5f))
            {
                e.Graphics.DrawPath(borderPen, path);
            }
        }

        // Task 6.2: Universal View-Switcher System
        private void LoadSubForm(Form subForm)
        {
            if (panelMainContent.Controls.Count > 0)
            {
                panelMainContent.Controls[0].Dispose();
            }

            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;

            panelMainContent.Controls.Add(subForm);
            panelMainContent.Tag = subForm;
            subForm.Show();
        }

        // Task 6.3: Logout Dialog Link
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out of the Admin panel?", "System Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

    }
}