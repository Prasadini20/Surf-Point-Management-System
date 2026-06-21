 // MySQL client එක අමතක කරන්න එපා
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
        // දැනට ලොග් වී සිටින Customer ගේ ID එක (උදාහරණයක් ලෙස 1 දමා ඇත)
        private int currentCustomerID = 1;

        public Customer_Dashboard()
        {
            InitializeComponent();
        }

        private void Customer_Dashboard_Load(object sender, EventArgs e)
        {
            // Logo එක රවුම් කිරීමට
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, pbHeaderLogo.Width, pbHeaderLogo.Height);
            pbHeaderLogo.Region = new Region(gp);

            // Dashboard එක load වෙද්දීම දත්ත ගණනය කර පෙන්වීම
            LoadDashboardOverview();
        }

        private void LoadDashboardOverview()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();

                    // 1. Total Bookings ගණන සෙවීම (COUNT)
                    string queryTotalBookings = "SELECT COUNT(*) FROM bookings WHERE CustomerID = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(queryTotalBookings, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", currentCustomerID);
                        label7.Text = cmd.ExecuteScalar().ToString();
                    }

                    // 2. Surfboard Viewed ගණන සෙවීම
                    string queryViews = "SELECT ViewCount FROM customer_activity WHERE CustomerID = @customerID";
                    using (MySqlCommand cmd = new MySqlCommand(queryViews, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerID", currentCustomerID);
                        object result = cmd.ExecuteScalar();
                        label8.Text = result != null ? result.ToString() : "0";
                    }

                    // 3. Last Booking එකේ සිට ගතවූ දින ගණන සෙවීම (DATEDIFF සහ BookingDate)
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
                           label9.Text = "No Bookings"; // කිසිම booking එකක් නැත්නම්
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        // --- View Count එක එකක් වැඩි කරන (Increment) Function එක ---
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

        // --- BUTTON CLICKS (NAVIGATION) ---

        // Make Bookings Button
        private void btnMakeBookings_Click(object sender, EventArgs e)
        {
            Booking_Form bookingForm = new Booking_Form();
            bookingForm.Show();
            this.Hide();
        }

        // View Surfboards Button
        private void btnViewSurfboards_Click(object sender, EventArgs e)
        {
            UpdateViewCount(); // ක්ලික් කරන වාරයක් පාසා count එක වැඩි කරයි

            view_surfboard viewSurfboard = new view_surfboard();
            viewSurfboard.Show();
            this.Hide();
        }

        // View Services Button
        private void btnViewServices_Click(object sender, EventArgs e)
        {
            Service servicesForm = new Service();
            servicesForm.Show();
            this.Hide();
        }

        // Logout Button
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
    }
}