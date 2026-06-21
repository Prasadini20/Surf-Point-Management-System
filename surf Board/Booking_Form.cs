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

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            lblCustomerID.Text = UserSession.LoggedCustomerID;
            LoadServices();
            LoadSurfboards();
        }

        private void LoadServices()
        {
            string query = "SELECT ServiceName, ServicePrice FROM Services;";

            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbService.DataSource = dt;
                cmbService.DisplayMember = "ServiceName";
                cmbService.ValueMember = "ServicePrice";
                cmbService.SelectedIndex = -1;
            }
        }

        private void LoadSurfboards()
        {

            string query = "SELECT BoardID, BoardType, Price FROM Surfboards;";

            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbSurfboardType.DataSource = dt;
                cmbSurfboardType.DisplayMember = "BoardType";
                cmbSurfboardType.ValueMember = "BoardID";
                cmbSurfboardType.SelectedIndex = -1;
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            decimal servicePrice = 0;
            decimal boardPrice = 0;

            if (cmbService.SelectedValue != null && decimal.TryParse(cmbService.SelectedValue.ToString(), out decimal sPrice))
                servicePrice = sPrice;


            txtTotalAmount.Text = (servicePrice + boardPrice).ToString("F2");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1 || cmbSurfboardType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all options!");
                return;
            }

            string query = "INSERT INTO Bookings (CustomerID, ServiceName, BoardID, BookingDate, TotalAmount) VALUES (@CID, @Service, @BID, @Date, @Total);";

            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", lblCustomerID.Text);
                    cmd.Parameters.AddWithValue("@Service", cmbService.Text);
                    cmd.Parameters.AddWithValue("@BID", cmbSurfboardType.SelectedValue); // BoardID යවනු ලැබේ
                    cmd.Parameters.AddWithValue("@Date", dtpBookingDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Total", txtTotalAmount.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    long bookingID = cmd.LastInsertedId;
                    MessageBox.Show("Booking Successful! Your Booking ID: " + bookingID);

                    Payment_Form pForm = new Payment_Form(bookingID.ToString(), txtTotalAmount.Text);
                    pForm.Show();
                    this.Close();
                }
            }
        }

        private void newBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Booking_Form newBooking = new Booking_Form();
            newBooking.Show();
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer_Form custForm = new Customer_Form();
            custForm.Show();
        }

        private void surfboardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_surfboard boardForm = new view_surfboard();
            boardForm.Show();
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string query = "SELECT BookingID, ServiceName, BoardID, BookingDate, TotalAmount FROM Bookings;";

            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBookings.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data: " + ex.Message);
                }
            }
        }
    }
}
  
