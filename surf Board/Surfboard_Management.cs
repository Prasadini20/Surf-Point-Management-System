using MySql.Data.MySqlClient;
using surf_Board;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Surfboard_Management : Form
    {
        public Surfboard_Management()
        {
            InitializeComponent();
        }

        private void Surfboard_Management_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            DisplayData();
            textBoardID.ReadOnly = true;
        }

        private void LoadComboBoxData()
        {
            cmbBoardType.Items.Clear();
            cmbBoardType.Items.AddRange(new object[] { "Shortboard", "Longboard", "Fish", "Funboard", "Hybrid", "Soft Top" });
            cmbBoardType.SelectedIndex = 0;

            cmbCondition.Items.Clear();
            cmbCondition.Items.AddRange(new object[] { "New", "Good", "Fair", "Damaged" });
            cmbCondition.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "Available", "Rented", "Maintenance" });
            cmbStatus.SelectedIndex = 0;
        }

        private void DisplayData()
        {
            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM surfboards";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvSurfboards.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Please enter the price.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO surfboards (BoardType, ConditionType, Price, Status) VALUES (@type, @cond, @price, @status)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@type", cmbBoardType.Text);
                        cmd.Parameters.AddWithValue("@cond", cmbCondition.Text);
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Surfboard Added Successfully to Database!");
                    }
                }
                DisplayData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting data: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoardID.Text))
            {
                MessageBox.Show("Select a record from the grid to update.");
                return;
            }

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE surfboards SET BoardType=@type, ConditionType=@cond, Price=@price, Status=@status WHERE BoardID=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@type", cmbBoardType.Text);
                        cmd.Parameters.AddWithValue("@cond", cmbCondition.Text);
                        cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(txtPrice.Text));
                        cmd.Parameters.AddWithValue("@status", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@id", textBoardID.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated Successfully!");
                    }
                }
                DisplayData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoardID.Text))
            {
                MessageBox.Show("Select a record from the grid to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No) return;

            try
            {
                using (MySqlConnection conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM surfboards WHERE BoardID=@id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", textBoardID.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully!");
                    }
                }
                DisplayData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting data: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoardID.Clear();
            txtPrice.Clear();
            cmbBoardType.SelectedIndex = 0;
            cmbCondition.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;
        }

        private void dgvSurfboards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSurfboards.Rows[e.RowIndex];

                textBoardID.Text = row.Cells["BoardID"].Value.ToString();
                cmbBoardType.Text = row.Cells["BoardType"].Value.ToString();
                cmbCondition.Text = row.Cells["ConditionType"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to go back to Admin Dashboard?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {

                Admin_Dashboard adminDashboard = new Admin_Dashboard();
                adminDashboard.Show();
                this.Hide();
            }
        }
       

        private void Surfboard_Management_FormClosing(object sender, FormClosingEventArgs e)
        {


            Application.Exit();
        }
    }
}
    
