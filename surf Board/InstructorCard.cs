using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class InstructorCard : UserControl
    {
        public InstructorCard()
        {
            InitializeComponent();
        }
            public void SetInstructorDetails(string name, string experience, string status)
        {
            lblInstructorName.Text = name;
            lblExperience.Text = "Experience : " + experience + " Years";
            lblStatus.Text = status;
        }
    
    }
}
