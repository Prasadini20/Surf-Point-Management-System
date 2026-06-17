using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Report_Form : Form
    {
        // Oyage Booking form eke thiyena connection string ekama damma machan
        MySqlConnection conn = new MySqlConnection("server=localhost;database=SurfSchoolDB;uid=root;pwd=;");

        public Report_Form()
        {
            InitializeComponent();
        }

        // Form load weddi select box eka default thiyaganna
        private void Report_Form_Load(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        // GENERATE REPORT BUTTON CLICK
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Validation: ComboBox eka select karala nathnam warning ekak denawa
            if (cmbReportType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a report type first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedReport = cmbReportType.SelectedItem.ToString();
            string query = "";

            // Oyage database tables scene ekata galapenna queries tika
            if (selectedReport == "Booking Report")
            {
                query = "SELECT * FROM Bookings WHERE BookingDate BETWEEN @FromDate AND @ToDate";
            }
            else if (selectedReport == "Payment Report")
            {
                // Payment date field eka database eke thiyena widiyata check karanna machan
                query = "SELECT * FROM Payments WHERE PaymentDate BETWEEN @FromDate AND @ToDate";
            }
            else if (selectedReport == "Customer Report")
            {
                // Customer form eke date ekak track wenawa nam e field eka methana danna
                query = "SELECT * FROM Customers WHERE RegisteredDate BETWEEN @FromDate AND @ToDate";
            }

            // Data load karana method eka call කරනවා
            LoadReportData(query);
        }

        // DATABASE DATA LOAD METHOD
        private void LoadReportData(string sqlQuery)
        {
            try
            {
                // Database connection open kirima safely
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                // DateTimePicker walin select karana dates deka parameters widiyata pass karanawa
                cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Oyage DataGridView (dgvReports) ekata data set kirima
                dgvReports.DataSource = dt;

                // Data mukuth nathnam user ta message ekak denawa
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the report... " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Connection eka aniwarenma close karanawa oyage parana code eke wagema
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        // CLEAR BUTTON (Optional but good to have)
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            dgvReports.DataSource = null; // Grid eka clear karanawa
        }
    }
}
