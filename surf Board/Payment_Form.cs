using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Payment_Form : Form
    {
        // Connection string for XAMPP MySQL database
        private string connectionString = "server=localhost;database=SurfSchoolDB;uid=root;pwd=;";

        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            // Database-dependent methods are commented out for testing the UI structure.
            // Uncomment these lines once the database and tables are created.

            // LoadBookingIDs();
            // LoadPaymentData();

            ClearFields();
        }

        // 1. Method to load Booking IDs into the ComboBox
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

        // 2. Method to load all payment records into the DataGridView
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

        // 3. Click event for the Pay (Save) button
        private void btnPay_Click(object sender, EventArgs e)
        {
            // Validation: Check if any fields are empty
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

                // Refresh the grid and clear input fields
                LoadPaymentData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. Click event for the Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // 5. Helper method to reset all fields to default state
        private void ClearFields()
        {
            cmbBookingID.SelectedIndex = -1;
            txtAmount.Clear();
            cmbMethod.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }
    }
}
