using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Dashboard dashboard = new Customer_Dashboard();

            dashboard.Show();

            this.Close();
        }


    }
}
