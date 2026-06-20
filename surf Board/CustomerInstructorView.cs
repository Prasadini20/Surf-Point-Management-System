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
            InstructorCard card1 = new InstructorCard();

            card1.SetInstructorDetails(
                "John Silva",
                "5",
                "Available"
            );

            flpInstructors.Controls.Add(card1);
        }
    }
}
