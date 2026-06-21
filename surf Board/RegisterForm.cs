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
            // 🚪 1. Background එකේ දැනටමත් හැංගිලා තියෙන Form1 එක සොයාගන්නවා
            Form loginForm = Application.OpenForms["Form1"];

            if (loginForm != null)
            {
                // 🔓 2. ඒ පරණ Form1 එක නැවත පෙන්වනවා
                loginForm.Show();

                // ❌ 3. වැදගත්ම දේ: මේ Register Form එක Close කරන්නේ නැතුව, මේක විතරක් Hide කරනවා!
                // (Close කළොත් මුළු ඇප් එකම crash වෙලා වැහෙන එක මේකෙන් නවතිනවා)
                this.Hide();
            }
            else
            {
                // 🆕 මොකක් හරි හේතුවකින් Form1 එක නැත්තම් විතරක් අලුත් එකක් හදලා පෙන්වනවා
                Form1 newLoginForm = new Form1();
                newLoginForm.Show();
                this.Hide();
            }
        }
    }
}