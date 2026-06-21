using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbUserType.Items.Clear();
            cmbUserType.Items.Add("Admin");
            cmbUserType.Items.Add("Customer");
            cmbUserType.SelectedIndex = 0;

            txtPassword.PasswordChar = '●';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userType = cmbUserType.SelectedItem.ToString();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Username and Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    connection.Open();

                    string query = "";
                    if (userType == "Admin")
                    {
                        query = "SELECT COUNT(*) FROM admins WHERE Username = @Username AND Password = @Password";
                    }
                    else if (userType == "Customer")
                    {
                        query = "SELECT COUNT(*) FROM customers WHERE Username = @Username AND Password = @Password";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show($"Login Successful as {userType}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (userType == "Admin")
                            {
                                Admin_Dashboard adminDash = new Admin_Dashboard();
                                adminDash.Show();
                            }
                            else if (userType == "Customer")
                            {
                                Customer_Dashboard customerDash = new Customer_Dashboard();
                                customerDash.Show();
                            }

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show($"Invalid Username or Password for {userType}. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }
    }
}