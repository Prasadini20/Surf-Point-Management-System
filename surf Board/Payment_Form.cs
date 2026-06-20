using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace surf_Board
{
    public partial class Payment_Form : Form
    {
        string connString = "server=localhost;database=surf_point_db;uid=root;pwd=sql1234@;";

        // දැන් මෙතනට එන්නේ Label එකට දාන්න ඕන අගයන් දෙක
        public Payment_Form(string bookingID, string amount)
        {
            InitializeComponent();

            // ComboBox එකක් නෙවෙයි දැන් තියෙන්නේ, ඒ නිසා කෙලින්ම Label එකට දාන්න
            label5.Text = bookingID;
            txtAmount.Text = amount;

            txtAmount.ReadOnly = true; // මිල වෙනස් කරන්න බැහැ
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // 1. validation එක හරිද බලමු
            if (cmbMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Select method!");
                return;
            }

            // 2. Database එකට යවන්නේ නැතුව test කිරීම
            // මෙතනදී label5 එකේ තියෙන්නේ Booking_Form එකෙන් එවපු "999" අගයයි
            string displayMessage = "Payment successful for Booking ID: " + label5.Text +
                                    "\nAmount: " + txtAmount.Text +
                                    "\nMethod: " + cmbMethod.SelectedItem.ToString();

            MessageBox.Show(displayMessage);

            // 3. වැඩේ හරි නම් ෆෝම් එක වහන්න
            this.Close();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            // මේක මෙතන තියෙන්න ඕනේ Designer එක හරි යන්න
        }

        // Clear button එකේදී Booking ID label එක clear කරන්න එපා
        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbMethod.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }


        private void label5_Click(object sender, EventArgs e)
        {
            // මේක මෙතන තියෙන්න ඕනේ Designer එක හරි යන්න
        }
    }
}