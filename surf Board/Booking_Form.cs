using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Booking_Form : Form
    {
       
        MySqlConnection conn = new MySqlConnection("server=localhost;database=SurfSchoolDB;uid=root;pwd=;");

        public Booking_Form()
        {
            InitializeComponent();
        }

        
        private void Booking_Form_Load(object sender, EventArgs e)
        {
            LoadBookingData();
            LoadCustomerIDs();
            ClearFields();
        }

        
        private void LoadBookingData()
        {
            try
            {
                string query = "SELECT * FROM Bookings";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBookings.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data... " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LoadCustomerIDs()
        {
            try
            {
                string query = "SELECT CustomerID FROM Customers";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCustomerID.DataSource = dt;
                cmbCustomerID.DisplayMember = "CustomerID";
                cmbCustomerID.ValueMember = "CustomerID";
                cmbCustomerID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Customer ID could not be loaded.. " + ex.Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cmbCustomerID.SelectedIndex == -1 || cmbSurfboardType.SelectedIndex == -1 || txtDuration.Value <= 0)
            {
                MessageBox.Show("Please enter all details correctly! Duration must be greater than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO Bookings (CustomerID, SurfboardType, BookingDate, Duration) VALUES (@CustomerID, @Type, @Date, @Duration)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CustomerID", cmbCustomerID.Text);
                cmd.Parameters.AddWithValue("@Type", cmbSurfboardType.Text);
                cmd.Parameters.AddWithValue("@Date", dtpBookingDate.Value.Date);
                cmd.Parameters.AddWithValue("@Duration", txtDuration.Value); 

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Booking successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadBookingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error...! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingID.Text))
            {
                MessageBox.Show("Please select the relevant booking from the grid to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "UPDATE Bookings SET CustomerID=@CustomerID, SurfboardType=@Type, BookingDate=@Date, Duration=@Duration WHERE BookingID=@BookingID";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@BookingID", txtBookingID.Text);
                cmd.Parameters.AddWithValue("@CustomerID", cmbCustomerID.Text);
                cmd.Parameters.AddWithValue("@Type", cmbSurfboardType.Text);
                cmd.Parameters.AddWithValue("@Date", dtpBookingDate.Value.Date);
                cmd.Parameters.AddWithValue("@Duration", txtDuration.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Booking details successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearFields();
                LoadBookingData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating... " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (conn.State == ConnectionState.Open) conn.Close();
            }
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingID.Text))
            {
                MessageBox.Show("Please select the relevant booking from the grid to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this booking?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM Bookings WHERE BookingID=@BookingID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookingID", txtBookingID.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("The booking was successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                    LoadBookingData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting..." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        
        private void dgvBookings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBookings.Rows[e.RowIndex];

                txtBookingID.Text = row.Cells["BookingID"].Value?.ToString() ?? "";
                cmbCustomerID.Text = row.Cells["CustomerID"].Value?.ToString() ?? "";
                cmbSurfboardType.Text = row.Cells["SurfboardType"].Value?.ToString() ?? "";

                if (row.Cells["BookingDate"].Value != DBNull.Value && row.Cells["BookingDate"].Value != null)
                {
                    dtpBookingDate.Value = Convert.ToDateTime(row.Cells["BookingDate"].Value);
                }

                if (row.Cells["Duration"].Value != DBNull.Value && row.Cells["Duration"].Value != null)
                {
                    txtDuration.Value = Convert.ToInt32(row.Cells["Duration"].Value);
                }
            }
        }

        
        private void ClearFields()
        {
            txtBookingID.Clear();
            cmbCustomerID.SelectedIndex = -1;
            cmbSurfboardType.SelectedIndex = -1;
            dtpBookingDate.Value = DateTime.Now;
            txtDuration.Value = 1; 
        }
    }
}