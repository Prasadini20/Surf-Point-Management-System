using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Report_Form : Form
    {
        public Report_Form()
        {
            InitializeComponent();
        }

        // 🔐 ඔයාගේ මැෂින් එකේදී විතරක් කනෙක්ෂන් එක මාරු කරන රහස් මෙතඩ් එක
        private MySqlConnection GetLocalSafeConnection()
        {
            // මුලින්ම ඔයාලගේ පොදු DBConnection එකෙන් සාමාන්‍ය කනෙක්ෂන් එක ගන්නවා (password නැති එක)
            MySqlConnection conn = DBConnection.GetConnection();

            // ඔයාගේ Laptop එකේදී විතරක් password එක ඇතුළත් කරලා connection string එක ඔයාගේ එකට මාරු කරනවා
            // ඩේටාබේස් නම aquaridedb ලෙස නිවැරදි කලා
            if (Environment.MachineName == "LAPTOP-S723VTT7")
            {
                conn.ConnectionString = "server=localhost;user=root;password=sql1234@;database=aquaridedb";
            }

            return conn;
        }

        private void Report_Form_Load(object sender, EventArgs e)
        {
            LoadReportTypes();
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        private void LoadReportTypes()
        {
            cmbReportType.Items.Clear();
            cmbReportType.Items.Add("Booking Report");
            cmbReportType.Items.Add("Payment Report");
            cmbReportType.Items.Add("Customer Report");
            cmbReportType.SelectedIndex = -1;
        }

        // GENERATE REPORT BUTTON CLICK
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cmbReportType.SelectedItem.ToString();
            string query = "";

            if (selectedReport == "Booking Report")
            {
                query = "SELECT * FROM Bookings WHERE BookingDate BETWEEN @FromDate AND @ToDate";
            }
            else if (selectedReport == "Payment Report")
            {
                query = "SELECT * FROM Payments WHERE PaymentDate BETWEEN @FromDate AND @ToDate";
            }
            else if (selectedReport == "Customer Report")
            {
                query = "SELECT * FROM Customers";
            }

            LoadReportData(query, selectedReport);
        }

        private void LoadReportData(string sqlQuery, string reportType)
        {
            try
            {
                // අපේ GetLocalSafeConnection() එකෙන් කනෙක්ෂන් එක ගන්නවා
                using (MySqlConnection conn = GetLocalSafeConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand(sqlQuery, conn))
                    {
                        if (reportType != "Customer Report")
                        {
                            cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                            cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);
                        }

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvReports.DataSource = dt;

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No records found for the selected criteria.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the report... " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            dgvReports.DataSource = null;
        }
    }
}