
using MySql.Data.MySqlClient;
using Surfing_Management_System;
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

            LoadNextInstructorID();

            // Matches the menu strip background to the exact top color of your gradient
            menuStrip1.BackColor = Color.FromArgb(43, 181, 212);

            // ================== PASTE IT RIGHT HERE ==================
            dgvInstructor.EnableHeadersVisualStyles = false;
            dgvInstructor.BackgroundColor = Color.White; // Keeps the bottom area clean and white

            // Rich dark blue/teal for high contrast and readability
            dgvInstructor.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 75, 115);
            dgvInstructor.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Crisp white text
            dgvInstructor.ColumnHeadersDefaultCellStyle.Font = new Font(dgvInstructor.Font, FontStyle.Bold);
            // =========================================================

            LoadInstructors();

            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Busy");
            cmbStatus.Items.Add("On Leave");

        }

        private void dgvInstructor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtInstructorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" ||
                txtContact.Text == "" ||
                txtExperience.Text == "" ||
                cmbStatus.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }

            string phoneInput = txtContact.Text.Trim();
            long output;
            if (phoneInput.Length != 10 || !long.TryParse(phoneInput, out output))
            {
                MessageBox.Show("Please enter a valid 10-digit phone number.", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query =
                "INSERT INTO instructors(Name,ContactNumber,ExperienceYears,AvailabilityStatus) VALUES(@Name,@Contact,@Experience,@Status)";

                MySqlCommand cmd =
                new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Experience", txtExperience.Text);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                
                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Instructor Added Successfully");

                LoadInstructors();

                ClearFields();

                LoadNextInstructorID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtInstructorID.Text == "")
            {
                MessageBox.Show("Select Instructor");
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query =
                "UPDATE instructors SET Name=@Name,ContactNumber=@Contact,ExperienceYears=@Experience,AvailabilityStatus=@Status WHERE InstructorID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtInstructorID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text);
                cmd.Parameters.AddWithValue("@Experience", txtExperience.Text);
                cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);
                

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Instructor Updated");

                LoadInstructors();

                ClearFields();

                LoadNextInstructorID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtInstructorID.Text == "")
            {
                MessageBox.Show("Select Instructor");
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query = "DELETE FROM instructors WHERE InstructorID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtInstructorID.Text);

                cmd.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Instructor Deleted");

                LoadInstructors();

                ClearFields();

                LoadNextInstructorID();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearchID.Text == "")
            {
                MessageBox.Show("Enter Instructor ID");
                return;
            }

            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query = "SELECT * FROM instructors WHERE InstructorID=@ID";

                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@ID", txtSearchID.Text);

                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    txtInstructorID.Text = dr["InstructorID"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtContact.Text = dr["ContactNumber"].ToString();
                    txtExperience.Text = dr["ExperienceYears"].ToString();
                    cmbStatus.Text = dr["AvailabilityStatus"].ToString();
                   
                }
                else
                {
                    MessageBox.Show("Instructor Not Found");
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

            txtName.Clear();
            txtContact.Clear();
            txtExperience.Clear();
            cmbStatus.SelectedIndex = -1;

            LoadNextInstructorID();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {

        }

        private void ClearFields()
        {

            txtName.Clear();
            txtContact.Clear();
            txtExperience.Clear();
            cmbStatus.SelectedIndex = -1;

            LoadNextInstructorID();
        }

        private void LoadInstructors()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query = "SELECT * FROM instructors";

                MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvInstructor.DataSource = dt;

               

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void LoadNextInstructorID()
        {
            try
            {
                MySqlConnection con = DBConnection.GetConnection();

                con.Open();

                string query = "SELECT IFNULL(MAX(InstructorID),0)+1 FROM instructors";

                MySqlCommand cmd = new MySqlCommand(query, con);

                txtInstructorID.Text = cmd.ExecuteScalar().ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void InstructorForm_Paint(object sender, PaintEventArgs e)
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

        private void dgvInstructor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvInstructor.Rows[e.RowIndex];

                txtInstructorID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtContact.Text = row.Cells[2].Value.ToString();
                txtExperience.Text = row.Cells[3].Value.ToString();
                cmbStatus.Text = row.Cells[4].Value.ToString();
                
            }
        }

       

       
    }


}