using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class InstructorForm : Form
    {
        public InstructorForm()
        {
            InitializeComponent();
        }

        private void dgvInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtInstructorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInstructorID.Text == "" ||
               txtInstructorName.Text == "" ||
               txtContact.Text == "" ||
               txtExperience.Text == "" ||
               txtStatus.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {
                dgvInstructor.Rows.Add(
                    txtInstructorID.Text,
                    txtInstructorName.Text,
                    txtContact.Text,
                    txtExperience.Text,
                    txtStatus.Text
                );

                MessageBox.Show("Instructor Added Successfully");

                txtInstructorID.Clear();
                txtInstructorName.Clear();
                txtContact.Clear();
                txtExperience.Clear();
                txtStatus.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dgvInstructor.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInstructor.SelectedRows[0];

                row.Cells[0].Value = txtInstructorID.Text;
                row.Cells[1].Value = txtInstructorName.Text;
                row.Cells[2].Value = txtContact.Text;
                row.Cells[3].Value = txtExperience.Text;
                row.Cells[4].Value = txtStatus.Text;

                MessageBox.Show("Instructor Updated Successfully");
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInstructor.SelectedRows.Count > 0)
            {
                dgvInstructor.Rows.RemoveAt(
                    dgvInstructor.SelectedRows[0].Index
                );

                MessageBox.Show("Instructor Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchID = txtInstructorID.Text;

            foreach (DataGridViewRow row in dgvInstructor.Rows)
            {
                if (row.Cells[0].Value != null &&
                    row.Cells[0].Value.ToString() == searchID)
                {
                    row.Selected = true;

                    txtInstructorID.Text = row.Cells[0].Value.ToString();
                    txtInstructorName.Text = row.Cells[1].Value.ToString();
                    txtContact.Text = row.Cells[2].Value.ToString();
                    txtExperience.Text = row.Cells[3].Value.ToString();
                    txtStatus.Text = row.Cells[4].Value.ToString();

                    MessageBox.Show("Instructor Found");
                    return;
                }
            }

            MessageBox.Show("Instructor Not Found");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInstructorID.Clear();
            txtInstructorName.Clear();
            txtContact.Clear();
            txtExperience.Clear();
            txtStatus.Clear();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }
    }


}
