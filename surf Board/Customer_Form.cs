using MySql.Data.MySqlClient;
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

            // Matches the menu strip background to the exact top color of your gradient
            menuStrip1.BackColor = Color.FromArgb(43, 181, 212);

            dgvCustomer.EnableHeadersVisualStyles = false;
            dgvCustomer.BackgroundColor = Color.White; // Keeps the bottom area clean and white

            // A deep, rich ocean dark blue for high contrast and readability
            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 75, 115);
            dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Crisp white text
            dgvCustomer.ColumnHeadersDefaultCellStyle.Font = new Font(dgvCustomer.Font, FontStyle.Bold);
            LoadCustomers();



            try
            {
                var con = DBConnection.GetConnection();
                con.Open();
                MessageBox.Show("Database Connected Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message);
            }


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
        cmbSkill.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query = "INSERT INTO customers(Name, PhoneNumber, Email, Country, SkillLevel) VALUES(@Name,@Phone,@Email,@Country,@Skill)";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@Skill", cmbSkill.Text);

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

                txtCustomerID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                txtCountry.Text = row.Cells[4].Value.ToString();
                cmbSkill.Text = row.Cells[5].Value.ToString();
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

                string query = "UPDATE customers SET Name=@Name, PhoneNumber=@Phone, Email=@Email, Country=@Country, SkillLevel=@Skill WHERE CustomerID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@Skill", cmbSkill.Text);

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
                    txtName.Text = dr["Name"].ToString();
                    txtPhone.Text = dr["PhoneNumber"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtCountry.Text = dr["Country"].ToString();
                    cmbSkill.Text = dr["SkillLevel"].ToString();
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
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtCountry.Clear();
            cmbSkill.SelectedIndex = -1;
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
         Color.FromArgb(43, 181, 212),  // The gorgeous light ocean teal from your image palette!
         Color.White,                  // Fades into clean white at the bottom
         90F))                          // 90 degrees handles top-to-bottom fading
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
