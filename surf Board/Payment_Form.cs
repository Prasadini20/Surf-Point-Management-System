using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Payment_Form : Form
    {
        // පොදු DBConnection එක වෙනස් නොකර, මේ Form එක ඇතුළේ විතරක් පාවිච්චි කරන්න 
        // string connString එක අයින් කරලා පහත ක්‍රමය (Method) භාවිතා කරනවා.

        public Payment_Form(string bookingID, string amount)
        {
            InitializeComponent();

            label5.Text = bookingID;
            txtAmount.Text = amount;

            txtAmount.ReadOnly = true;
        }

        // 🔐 ඔයාගේ මැෂින් එකේදී විතරක් කනෙක්ෂන් එක මාරු කරන රහස් මෙතඩ් එක
        private MySqlConnection GetLocalSafeConnection()
        {
            // මුලින්ම ඔයාලගේ පොදු DBConnection එකෙන් සාමාන්‍ය කනෙක්ෂන් එක ගන්නවා (password නැති එක)
            MySqlConnection conn = DBConnection.GetConnection();

            // ඔයාගේ Laptop එකේදී විතරක් password එක ඇතුළත් කරලා connection string එක ඔයාගේ එකට මාරු කරනවා
            if (Environment.MachineName == "LAPTOP-S723VTT7")
            {
                conn.ConnectionString = "server=localhost;user=root;password=sql1234@;database=aquaridedb";
            }

            return conn;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select a payment method!");
                return;
            }

            try
            {
                // අපි හදපු GetLocalSafeConnection() එකෙන් කනෙක්ෂන් එක ගන්නවා
                using (MySqlConnection conn = GetLocalSafeConnection())
                {
                    string query = "INSERT INTO Payments (BookingID, Amount, PaymentMethod, PaymentDate) VALUES (@BID, @Amount, @Method, @Date)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BID", label5.Text);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                        cmd.Parameters.AddWithValue("@Method", cmbMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Payment Successful!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMethod.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}