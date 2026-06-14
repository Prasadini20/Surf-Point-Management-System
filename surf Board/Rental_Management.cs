using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace surf_Board
{
    public partial class Rental_Management : Form
    {
        List<Rental> rentals = new List<Rental>();
        public Rental_Management()
        {
            InitializeComponent();
        }

        private void Rental_Management_Load(object sender, EventArgs e)
        {
            cmbCustomer.Items.AddRange(new string[]
            {
        "Emma Johnson",
        "Liam Brown",
        "Olivia Smith"
            });

            cmbSurfBoard.Items.AddRange(new string[]
            {
        "B001 - Longboard",
        "B002 - Shortboard",
        "B003 - Fishboard"
            });

            txtPricePerHour.ReadOnly = true;
            txtTotalAmount.ReadOnly = true;
        }

        private void cmbSurfBoard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSurfBoard.Text.Contains("B001"))
            {
                txtPricePerHour.Text = "2500";
            }
            else if (cmbSurfBoard.Text.Contains("B002"))
            {
                txtPricePerHour.Text = "2000";
            }
            else if (cmbSurfBoard.Text.Contains("B003"))
            {
                txtPricePerHour.Text = "1800";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtHours.Text == "")
            {
                MessageBox.Show("Enter rental hours.");
                return;
            }

            int hours = int.Parse(txtHours.Text);
            decimal price = decimal.Parse(txtPricePerHour.Text);

            txtTotalAmount.Text = (hours * price).ToString();
        }

        private void btnIssueBoard_Click(object sender, EventArgs e)
        {
            if (txtRentalID.Text == "" ||
                cmbCustomer.Text == "" ||
                cmbSurfBoard.Text == "" ||
                txtHours.Text == "" ||
                txtTotalAmount.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Rental rental = new Rental();

            rental.RentalID = txtRentalID.Text;
            rental.Customer = cmbCustomer.Text;
            rental.Surfboard = cmbSurfBoard.Text;
            rental.IssueDate = dtpIssueDate.Value;
            rental.ReturnDate = dtpReturnDate.Value;
            rental.Hours = int.Parse(txtHours.Text);
            rental.PricePerHour = decimal.Parse(txtPricePerHour.Text);
            rental.TotalAmount = decimal.Parse(txtTotalAmount.Text);
            rental.Status = "Issued";

            rentals.Add(rental);

            RefreshGrid();

            MessageBox.Show("Board issued successfully.");

            ClearFields();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            foreach (Rental rental in rentals)
            {
                if (rental.RentalID == txtRentalID.Text)
                {
                    rental.Status = "Returned";

                    RefreshGrid();

                    MessageBox.Show("Board returned successfully.");

                    ClearFields();

                    return;
                }
            }

            MessageBox.Show("Rental ID not found.");
        }

        private void dgvRentalHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRentalHistory.Rows[e.RowIndex];

                txtRentalID.Text = row.Cells[0].Value.ToString();
                cmbCustomer.Text = row.Cells[1].Value.ToString();
                cmbSurfBoard.Text = row.Cells[2].Value.ToString();

                dtpIssueDate.Value = Convert.ToDateTime(row.Cells[3].Value);
                dtpReturnDate.Value = Convert.ToDateTime(row.Cells[4].Value);

                txtHours.Text = row.Cells[5].Value.ToString();
                txtPricePerHour.Text = row.Cells[6].Value.ToString();
                txtTotalAmount.Text = row.Cells[7].Value.ToString();
            }
        }

        private void RefreshGrid()
        {
            dgvRentalHistory.DataSource = null;
            dgvRentalHistory.DataSource = rentals;
        }

        private void ClearFields()
        {
            txtRentalID.Clear();
            txtHours.Clear();
            txtPricePerHour.Clear();
            txtTotalAmount.Clear();

            cmbCustomer.SelectedIndex = -1;
            cmbSurfBoard.SelectedIndex = -1;

            dtpIssueDate.Value = DateTime.Now;
            dtpReturnDate.Value = DateTime.Now;

            txtRentalID.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
