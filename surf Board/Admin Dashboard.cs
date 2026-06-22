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
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            Customer_Form customerForm = new Customer_Form();
            customerForm.Show();
            this.Hide(); 
        }

        private void btnInstructorManagement_Click(object sender, EventArgs e)
        {
            InstructorForm instructorForm = new InstructorForm();
            instructorForm.Show();
            this.Hide();
        }

        private void btnSurfboardManagement_Click(object sender, EventArgs e)
        {
            Surfboard_Management surfboardForm = new Surfboard_Management();
            surfboardForm.Show();
            this.Hide();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["Form1"] != null)
            {
                Application.OpenForms["Form1"].Show();
            }
            else
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
            }

            this.Close();
        }

        private void Admin_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {


            Application.Exit();
        }
    }
}