using MySql.Data.MySqlClient;
using surf_Board;
using System;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();


            comboBox1.Items.Clear();
            comboBox1.Items.Add("Beginner");
            comboBox1.Items.Add("Intermediate");
            comboBox1.Items.Add("Advanced");
            comboBox1.Items.Add("Professional");
            comboBox1.SelectedIndex = 0;
        }

        private void btnRegisterSubmit_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtRegFullName.Text) ||
                string.IsNullOrWhiteSpace(txtRegUsername.Text) ||
                string.IsNullOrWhiteSpace(txtRegPassword.Text))
            {
                MessageBox.Show("Please fill in all the details!");
                return;
            }


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to register with this password?",
                                                       "Confirm Registration",
                                                       MessageBoxButtons.OKCancel,
                                                       MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    using (MySqlConnection conn = DBConnection.GetConnection())
                    {
                        conn.Open();
                        string query = "INSERT INTO customers (FullName, ContactNumber, Country, Email, SkillLevel, Username, Password) VALUES (@name, @contact, @country, @email, @skill, @user, @pass)";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", txtRegFullName.Text);
                            cmd.Parameters.AddWithValue("@contact", txtRegContact.Text);
                            cmd.Parameters.AddWithValue("@country", txtRegCountry.Text);
                            cmd.Parameters.AddWithValue("@email", txtRegEmail.Text);
                            cmd.Parameters.AddWithValue("@skill", comboBox1.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@user", txtRegUsername.Text);
                            cmd.Parameters.AddWithValue("@pass", txtRegPassword.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Successfully registered!");


                            Form1 login = new Form1();
                            login.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lnkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form loginForm = Application.OpenForms["Form1"];

            if (loginForm != null)
            {
                loginForm.Show();

                this.Hide();
            }
            else
            {
                Form1 newLoginForm = new Form1();
                newLoginForm.Show();
                this.Hide();
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            txtRegFullName.TextAlign = HorizontalAlignment.Left;
        }


    }
}