using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Booking_Form : Form
    {
        string connString = "server=localhost;database=surf_point_db;uid=root;pwd=sql1234@;";

        public Booking_Form()
        {
            InitializeComponent();
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
            using (MySqlConnection conn = new MySqlConnection(connString))
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
            using (MySqlConnection conn = new MySqlConnection(connString))
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
            if (cmbService.SelectedValue != null && decimal.TryParse(cmbService.SelectedValue.ToString(), out servicePrice)) { }
            if (cmbSurfboardType.SelectedValue != null && decimal.TryParse(cmbSurfboardType.SelectedValue.ToString(), out boardPrice)) { }
            txtTotalAmount.Text = (servicePrice + boardPrice).ToString("F2");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbService.SelectedIndex == -1 || cmbSurfboardType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select all options!");
                return;
            }

            // Database එකට සම්බන්ධ නොවී Test කිරීමට දාන කෑල්ල
            string testBookingID = "999"; // මෙතනට ඔයා කැමති ID එකක් දෙන්න
            string testAmount = txtTotalAmount.Text;

            // මෙතැනදී කෙලින්ම Payment Form එක පෙන්වනවා
            Payment_Form pForm = new Payment_Form(testBookingID, testAmount);
            pForm.Show();
            this.Hide();
        }
    }
}