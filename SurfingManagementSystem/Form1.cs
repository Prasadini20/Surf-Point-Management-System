using System;
using System.Windows.Forms;

namespace Surfing_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin__Click(object sender, EventArgs e)
        {
            // Simple verification test box
            MessageBox.Show("Code is executing correctly!");

            if (txtUsername_.Text == "admin" && txtPassword_.Text == "password123")
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                MainDashboard dashboard = new MainDashboard();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials entered.");
            }
        }
        private void chkShowPassword__CheckedChanged(object sender, EventArgs e)
        {
            // When checked, disable the system password character mask (reveals text)
            // When unchecked, enable the system password character mask (hides text)
            txtPassword_.UseSystemPasswordChar = !chkShowPassword_.Checked;
        }


        private void lnkForgotPassword__Click(object sender, EventArgs e)
        {
            MessageBox.Show("Username: admin\nPassword: password123");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {

        }

        private void lnkForgotPassword__Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Displays a helpful recovery popup when clicked
            MessageBox.Show("System Recovery:\n\nDefault Username: admin\nDefault Password: password123",
                            "Account Recovery",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }
    }
}