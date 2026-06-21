using MySql.Data.MySqlClient;
using surf_Board;
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

            menuStrip1.BackColor = Color.FromArgb(43, 181, 212);

            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.BackgroundColor = Color.White;

            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 75, 115);
            dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvCustomer.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCustomer.Font, FontStyle.Bold);

            LoadCustomers();

            
        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
                txtPhone.Text == "" ||
                txtEmail.Text == "" ||
                txtCountry.Text == "" ||
                cmbSkill.Text == "" ||
                txtUsername.Text == "" ||
                txtPassword.Text == ""
                )
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "INSERT INTO customers(FullName, ContactNumber, Email, Country, SkillLevel,Username,Password) VALUES(@Name, @Phone, @Email, @Country, @Skill,@Username,@Password)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@Skill", cmbSkill.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Added Successfully");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCountry.Clear();
            cmbSkill.SelectedIndex = -1;
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void LoadCustomers()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "SELECT * FROM customers";
                MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomer.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];

                txtCustomerID.Text = row.Cells["CustomerID"].Value.ToString();
                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtPhone.Text = row.Cells["ContactNumber"].Value.ToString();
                txtCountry.Text = row.Cells["Country"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                cmbSkill.Text = row.Cells["SkillLevel"].Value.ToString();
                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "DELETE FROM customers WHERE CustomerID=@ID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Deleted Successfully");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "UPDATE customers SET FullName=@Name, ContactNumber=@Phone, Email=@Email, Country=@Country, SkillLevel=@Skill WHERE CustomerID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@Skill", cmbSkill.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Customer Updated Successfully");
                LoadCustomers();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "SELECT * FROM customers WHERE CustomerID=@ID";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtName.Text = dr["FullName"].ToString();
                    txtPhone.Text = dr["ContactNumber"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtCountry.Text = dr["Country"].ToString();
                    cmbSkill.Text = dr["SkillLevel"].ToString();
                    txtUsername.Text = dr["UserName"].ToString();
                    txtPassword.Text = dr["Password"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer Not Found");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void txtSkill_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbSkill_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Customer_Form_Paint(object sender, PaintEventArgs e)
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


        private void Customer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {


            Application.Exit();
        }

    }
}
