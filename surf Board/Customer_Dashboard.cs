using MySql.Data.MySqlClient;
using Surfing_Management_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Customer_Dashboard : Form
    {
        private int currentCustomerID = 1;

        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pbHeaderLogo.Width, pbHeaderLogo.Height);
            pbHeaderLogo.Region = new Region(gp);

            LoadDashboardOverview();
        }

        private void LoadDashboardOverview()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    string queryTotalBookings = "SELECT COUNT(*) FROM bookings WHERE CustomerID = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(queryTotalBookings, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", currentCustomerID);
                        label7.Text = cmd.ExecuteScalar().ToString();
                    }

                    

                    string queryLastBooking = "SELECT DATEDIFF(NOW(), MAX(BookingDate)) FROM bookings WHERE CustomerID = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(queryLastBooking, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", currentCustomerID);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value && result != null)
                        {
                            label9.Text = result.ToString() + " Days Ago";
                        }
                        else
                        {
                           label9.Text = "No Bookings"; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        
        private void UpdateViewCount()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO customer_activity (CustomerID, ViewCount) VALUES (@customerID, 1) " +
                                   "ON DUPLICATE KEY UPDATE ViewCount = ViewCount + 1";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", currentCustomerID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch { /* Errors ආවොත් ignore කරන්න */ }
        }

        

       
        private void btnMakeBookings_Click(object sender, EventArgs e)
        {
            Booking_Form bookingForm = new Booking_Form();
            bookingForm.Show();
            this.Hide();
        }

        
        private void btnViewSurfboards_Click(object sender, EventArgs e)
        {
            UpdateViewCount(); 

            view_surfboard viewSurfboard = new view_surfboard();
            viewSurfboard.Show();
            this.Hide();
        }

        
        private void btnViewServices_Click(object sender, EventArgs e)
        {
            Service servicesForm = new Service();
            servicesForm.Show();
            this.Hide();
        }

       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void Customer_Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}