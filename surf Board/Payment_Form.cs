using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Payment_Form : Form
    {
        public Payment_Form(string bookingID, string amount)
        {
            InitializeComponent();

            label5.Text = bookingID;
            txtAmount.Text = amount;
            txtAmount.ReadOnly = true;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select a payment method!");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    string query = "INSERT INTO Payments (BookingID, Amount, PaymentMethod, Date) VALUES (@BID, @Amount, @Method, @Date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BID", label5.Text);
                        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text);
                        cmd.Parameters.AddWithValue("@Method", cmbMethod.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Customer_Dashboard cusDash = new Customer_Dashboard();
                cusDash.Show();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMethod.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            if (cmbMethod.Items.Count == 0)
            {
                cmbMethod.Items.Add("Cash");
                cmbMethod.Items.Add("Card");
                cmbMethod.Items.Add("Online Transfer");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Payment_Form_Paint(object sender, PaintEventArgs e)
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

