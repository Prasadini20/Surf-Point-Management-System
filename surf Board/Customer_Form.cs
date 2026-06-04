using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" ||
               txtName.Text == "" ||
               txtPhone.Text == "" ||
               txtEmail.Text == "" ||
               txtCountry.Text == "" ||
               txtSkill.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");

            }
            else
            {
                dgvCustomer.Rows.Add(
                    txtCustomerID.Text,
                    txtName.Text,
                    txtPhone.Text,
                    txtEmail.Text,
                    txtCountry.Text,
                    txtSkill.Text
                    );
                MessageBox.Show("Customer Added Successfully");

                txtCustomerID.Clear();
                txtName.Clear();
                txtPhone.Clear();
                txtEmail.Clear();
                txtCountry.Clear();
                txtSkill.Clear();

            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtCountry.Text = row.Cells[4].Value.ToString();
                txtSkill.Text = row.Cells[5].Value.ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)

            {
                dgvCustomer.Rows.RemoveAt(
                    dgvCustomer.SelectedRows[0].Index
                    );
                MessageBox.Show("Customer Deleted");
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row =
                    dgvCustomer.SelectedRows[0];

                row.Cells[0].Value = txtCustomerID.Text;
                row.Cells[1].Value = txtName.Text;
                row.Cells[2].Value = txtPhone.Text;
                row.Cells[3].Value = txtEmail.Text;
                row.Cells[4].Value = txtCountry.Text;
                row.Cells[5].Value = txtSkill.Text;

                MessageBox.Show("Customer Updated");
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtCustomerID.Text;

            foreach (DataGridViewRow row in dgvCustomer.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == searchID)
                {
                    row.Selected = true;

                    txtCustomerID.Text = row.Cells[0].Value.ToString();
                    txtName.Text = row.Cells[1].Value.ToString();
                    txtPhone.Text = row.Cells[2].Value.ToString();
                    txtEmail.Text = row.Cells[3].Value.ToString();
                    txtCountry.Text = row.Cells[4].Value.ToString();
                    txtSkill.Text = row.Cells[5].Value.ToString();

                    MessageBox.Show("Customer Found");
                    return;
                }
            }

            MessageBox.Show("Customer Not Found");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCountry.Clear();
            txtSkill.Clear();
        }
    }
}
