using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Payment_Form : Form
    {
        
        private string connectionString = "server=localhost;database=SurfSchoolDB;uid=root;pwd=;";

        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
           

            ClearFields();
        }

        
        private void LoadBookingIDs()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT BookingID FROM Bookings";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbBookingID.DataSource = dt;
                    cmbBookingID.DisplayMember = "BookingID";
                    cmbBookingID.ValueMember = "BookingID";
                    cmbBookingID.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Booking IDs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LoadPaymentData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Payments";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPayments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnPay_Click(object sender, EventArgs e)
        {
            
            if (cmbBookingID.SelectedIndex == -1 || string.IsNullOrEmpty(txtAmount.Text) || cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO Payments (BookingID, Amount, PaymentMethod, PaymentDate) VALUES (@BookingID, @Amount, @Method, @Date)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookingID", cmbBookingID.SelectedValue);
                        cmd.Parameters.AddWithValue("@Amount", decimal.Parse(txtAmount.Text));
                        cmd.Parameters.AddWithValue("@Method", cmbMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value.ToString("yyyy-MM-dd"));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                
                LoadPaymentData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
        private void ClearFields()
        {
            cmbBookingID.SelectedIndex = -1;
            txtAmount.Clear();
            cmbMethod.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }
    }
}
