using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Booking_Form : Form
    {
        // පොදු DBConnection එක වෙනස් නොකර, මේ Form එක ඇතුළේ විතරක් පාවිච්චි කරන්න 
        // string connString එක අයින් කරලා පහත ක්‍රමය (Method) භාවිතා කරනවා.

        public Booking_Form()
        {
            InitializeComponent();
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

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            lblCustomerID.Text = UserSession.LoggedCustomerID;
            LoadServices();
            LoadSurfboards();
        }

        private void LoadServices()
        {
            string query = "SELECT ServiceName, Price FROM Services;";

            // අපි හදපු GetLocalSafeConnection() එකෙන් කනෙක්ෂන් එක ගන්නවා
            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbService.DataSource = dt;
                cmbService.DisplayMember = "ServiceName";
                cmbService.ValueMember = "Price";
                cmbService.SelectedIndex = -1;
            }
        }

        private void LoadSurfboards()
        {
            string query = "SELECT Type, Price FROM Surfboards;";

            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbSurfboardType.DataSource = dt;
                cmbSurfboardType.DisplayMember = "Type";
                cmbSurfboardType.ValueMember = "Price";
                cmbSurfboardType.SelectedIndex = -1;
            }
        }

        private void CalculateTotal(object sender, EventArgs e)
        {
            decimal servicePrice = 0;
            decimal boardPrice = 0;

            // TryParse එකෙන් එන අගයන් නිවැරදිව Variable එකට Assign වන ලෙස හැදුවා
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1 || cmbSurfboardType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all options!");
                return;
            }

            string query = "INSERT INTO Bookings (CustomerID, ServiceName, SurfboardType, BookingDate, TotalAmount) VALUES (@CID, @Service, @Type, @Date, @Total);";
            long bookingID = 0;

            using (MySqlConnection conn = GetLocalSafeConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CID", lblCustomerID.Text);
                    cmd.Parameters.AddWithValue("@Service", cmbService.Text);
                    cmd.Parameters.AddWithValue("@Type", cmbSurfboardType.Text);
                    cmd.Parameters.AddWithValue("@Date", dtpBookingDate.Value.Date);
                    cmd.Parameters.AddWithValue("@Total", txtTotalAmount.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    bookingID = cmd.LastInsertedId;
                }
            }

            Payment_Form pForm = new Payment_Form(bookingID.ToString(), txtTotalAmount.Text);
            pForm.Show();
            this.Hide();
        }
    }
}