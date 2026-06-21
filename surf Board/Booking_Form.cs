using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Booking_Form : Form
    {
        public Booking_Form()
        {
            InitializeComponent();


            menuStrip1.BackColor = Color.FromArgb(43, 181, 212);

            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.BackgroundColor = Color.White;

            dgvBookings.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 75, 115);
            dgvBookings.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBookings.ColumnHeadersDefaultCellStyle.Font = new Font(dgvBookings.Font, FontStyle.Bold);


            cmbService.SelectedIndexChanged += CalculateTotal;
            cmbSurfboardType.SelectedIndexChanged += CalculateTotal;
        }

        public Booking_Form(string customerID) : this()
        {
            lblCustomerID.Text = customerID;
        }

        private void LoadServices()
        {
            string query = "SELECT ServiceName, ServicePrice FROM Services;";
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbService.DataSource = dt;
                    cmbService.DisplayMember = "ServiceName";
                    cmbService.ValueMember = "ServicePrice";
                    cmbService.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading services: " + ex.Message);
                }
            }
        }

        private void LoadSurfboards()
        {
            string query = "SELECT BoardID, BoardType, Price FROM Surfboards;";
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cmbSurfboardType.DataSource = dt;
                    cmbSurfboardType.DisplayMember = "BoardType";
                    cmbSurfboardType.ValueMember = "Price";
                    cmbSurfboardType.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading surfboards: " + ex.Message);
                }
            }
        }

        private string GetLatestCustomerIDFromDB()
        {
            string lastID = "1";
            string query = "SELECT CustomerID FROM customers ORDER BY CustomerID DESC LIMIT 1;";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        lastID = result.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching customer ID: " + ex.Message);
                }
            }
            return lastID;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1 || cmbSurfboardType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all options!");
                return;
            }

            if (string.IsNullOrEmpty(lblCustomerID.Text) || lblCustomerID.Text == "0")
            {
                MessageBox.Show("Customer ID is required to place a booking!");
                return;
            }

            string boardIDQuery = "SELECT BoardID FROM Surfboards WHERE BoardType = @BType LIMIT 1;";
            string selectedBoardID = "1";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmdBoard = new MySqlCommand(boardIDQuery, conn);
                    cmdBoard.Parameters.AddWithValue("@BType", cmbSurfboardType.Text);
                    object bIdResult = cmdBoard.ExecuteScalar();
                    if (bIdResult != null) selectedBoardID = bIdResult.ToString();
                }
                catch { }
            }

            string query = "INSERT INTO Bookings (CustomerID, ServiceName, BoardID, BookingDate, TotalAmount) VALUES (@CID, @Service, @BID, @Date, @Total);";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", lblCustomerID.Text);
                    cmd.Parameters.AddWithValue("@Service", cmbService.Text);
                    cmd.Parameters.AddWithValue("@BID", selectedBoardID);
                    cmd.Parameters.AddWithValue("@Date", dtpBookingDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Total", txtTotalAmount.Text);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();

                        long bookingID = cmd.LastInsertedId;
                        MessageBox.Show("Booking Successful! Your Booking ID: " + bookingID);

                        Payment_Form pForm = new Payment_Form(bookingID.ToString(), txtTotalAmount.Text);
                        pForm.Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Booking Failed: " + ex.Message);
                    }
                }
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            decimal servicePrice = 0;
            decimal boardPrice = 0;

            if (cmbService.SelectedValue != null && decimal.TryParse(cmbService.SelectedValue.ToString(), out decimal sPrice))
            {
                servicePrice = sPrice;
            }

            if (cmbSurfboardType.SelectedValue != null && decimal.TryParse(cmbSurfboardType.SelectedValue.ToString(), out decimal bPrice))
            {
                boardPrice = bPrice;
            }

            txtTotalAmount.Text = (servicePrice + boardPrice).ToString("F2");
        }

        private void GetNextBookingID()
        {
            string query = "SELECT Auto_increment FROM information_schema.tables WHERE table_schema = DATABASE() AND table_name = 'Bookings';";
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        txtBookingID.Text = result.ToString();
                        txtBookingID.ReadOnly = true;
                    }
                }
                catch { }
            }
        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblCustomerID.Text) || lblCustomerID.Text == "label_Customer_ID_Name")
            {
                if (!string.IsNullOrEmpty(UserSession.LoggedCustomerID))
                {
                    lblCustomerID.Text = UserSession.LoggedCustomerID;
                }
                else
                {
                    lblCustomerID.Text = GetLatestCustomerIDFromDB();
                }
            }

            LoadServices();
            LoadSurfboards();
            GetNextBookingID();
            LoadBookingGrid();
        }

        private void LoadBookingGrid()
        {
            string query = "SELECT BookingID, ServiceName, BoardID, BookingDate, TotalAmount FROM Bookings;";
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                try
                {
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvBookings.DataSource = dt;
                }
                catch { }
            }
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadBookingGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbService.SelectedIndex = -1;
            cmbSurfboardType.SelectedIndex = -1;
            txtTotalAmount.Text = "0.00";
            dtpBookingDate.Value = DateTime.Now;
            cmbService.Focus();
        }

        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking_Form newBooking = new Booking_Form(lblCustomerID.Text);
            newBooking.Show();
            this.Close();
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Dashboard cusdashForm = new Customer_Dashboard();
            cusdashForm.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Booking_Form_Paint(object sender, PaintEventArgs e)
        {

            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
         this.ClientRectangle,
         Color.FromArgb(43, 181, 212),
         Color.White,
         90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

       
    }
}