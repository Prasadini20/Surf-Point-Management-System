using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Admin_Dashboard : Form
    {
        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        // 👥 1. CUSTOMER MANAGEMENT බටන් එක ක්ලික් කළ විට
        private void btnCustomerManagement_Click(object sender, EventArgs e)
        {
            // Customer Management Form එක ඕපන් කිරීම (ඔයා හදපු ෆෝම් එකේ නම වෙනස් නම් ඒ නම මෙතනට දෙන්න)
            Customer_Form customerForm = new Customer_Form();
            customerForm.Show();
            this.Hide(); // Dashboard එක තාවකාලිකව සඟවයි
        }

        // 🏄‍♂️ 2. INSTRUCTOR MANAGEMENT බටන් එක ක්ලික් කළ විට
        private void btnInstructorManagement_Click(object sender, EventArgs e)
        {
            // Instructor Management Form එක ඕපන් කිරීම
            InstructorForm instructorForm = new InstructorForm();
            instructorForm.Show();
            this.Hide();
        }

        // 🛹 3. SURFBOARD MANAGEMENT බටන් එක ක්ලික් කළ විට
        private void btnSurfboardManagement_Click(object sender, EventArgs e)
        {
            // Surfboard Management Form එක ඕපන් කිරීම
            Surfboard_Management surfboardForm = new Surfboard_Management();
            surfboardForm.Show();
            this.Hide();
        }

        // 📜 4. VIEW NOTICES බටන් එක ක්ලික් කළ විට


        // 🔴 5. LOGOUT බටන් එක ක්ලික් කළ විට
        // 🔴 5. LOGOUT බටන් එක ක්ලික් කළ විට
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // 🚪 පරණ Form1 එක තවමත් background එකේ open වෙලා තියෙනවාදැයි බලනවා
            if (Application.OpenForms["Form1"] != null)
            {
                // තියෙනවා නම් ඒක පෙන්වනවා
                Application.OpenForms["Form1"].Show();
            }
            else
            {
                // 🆕 මොකක් හරි හේතුවකින් ඒක වැහිලා නම්, අලුතින්ම Form1 එකක් හදලා පෙන්වනවා
                Form1 loginForm = new Form1();
                loginForm.Show();
            }

            // ❌ ප්‍රධානම දේ: මේ Dashboard එක Hide කරන්නේ නැතුව Hide වෙනුවට සම්පූර්ණයෙන්ම Close කරලා මතකය නිදහස් කරනවා
            this.Hide();
        }
    }
}