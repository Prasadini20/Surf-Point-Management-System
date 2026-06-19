using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Report_Form : Form
    {
        
        MySqlConnection conn = new MySqlConnection("server=localhost;database=SurfSchoolDB;uid=root;pwd=;");

        public Report_Form()
        {
            InitializeComponent();
        }

        
        private void Report_Form_Load(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
        }

        
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
                
                query = "SELECT * FROM Customers WHERE RegisteredDate BETWEEN @FromDate AND @ToDate";
            }

            
            LoadReportData(query);
        }

        
        private void LoadReportData(string sqlQuery)
        {
            try
            {
                
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                MySqlCommand cmd = new MySqlCommand(sqlQuery, conn);

                
                cmd.Parameters.AddWithValue("@FromDate", dtpFrom.Value.Date);
                cmd.Parameters.AddWithValue("@ToDate", dtpTo.Value.Date);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                dgvReports.DataSource = dt;

                
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
                
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbReportType.SelectedIndex = -1;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            dgvReports.DataSource = null; // Grid eka clear karanawa
        }
    }
}
