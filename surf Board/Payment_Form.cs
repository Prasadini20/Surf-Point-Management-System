using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Payment_Form : Form
    {
        

        public Payment_Form(string bookingID, string amount)
        {
            InitializeComponent();

            label5.Text = bookingID;
            txtAmount.Text = amount;

            txtAmount.ReadOnly = true;
        }

        
        private MySqlConnection GetLocalSafeConnection()
        {
            
            MySqlConnection conn = DBConnection.GetConnection();

            
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