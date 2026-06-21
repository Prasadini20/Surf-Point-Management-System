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
    public partial class CustomerInstructorView : Form
    {
        public CustomerInstructorView()
        {
            InitializeComponent();
        }

        private void flpInstructors_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CustomerInstructorView_Load(object sender, EventArgs e)
        {
            LoadInstructorCards();
        }

        private void flpInstructors_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void LoadInstructorCards()
        {
            flpInstructors.Controls.Clear();

            try
            {
                MySqlConnection con = DBConnection.GetConnection();
                con.Open();

                string query = "SELECT Name, ExperienceYears, AvailabilityStatus, ImageName FROM instructors";

                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    InstructorCard card = new InstructorCard();

                    string name = dr["Name"].ToString();
                    string exp = dr["ExperienceYears"].ToString();
                    string status = dr["AvailabilityStatus"].ToString();
                    string image = dr["ImageName"].ToString();

                    card.SetInstructorDetails(name, exp, status, image);

                    card.Margin = new Padding(10);

                    flpInstructors.Controls.Add(card);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading instructors: " + ex.Message);
            }
        }
    }
}
