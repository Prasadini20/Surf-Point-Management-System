using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Surfboard_Management : Form
    {
        List<Surfboard> surfboards = new List<Surfboard>();

        public Surfboard_Management()
        {
            InitializeComponent();
        }

        private void Surfboard_Management_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            SetupGrid();
        }

        private void LoadComboBoxData()
        {
            cmbBoardType.Items.Add("Shortboard");
            cmbBoardType.Items.Add("Longboard");
            cmbBoardType.Items.Add("Fish");
            cmbBoardType.Items.Add("Funboard");
            cmbBoardType.SelectedIndex = 0;

            cmbCondition.Items.Add("New");
            cmbCondition.Items.Add("Good");
            cmbCondition.Items.Add("Fair");
            cmbCondition.Items.Add("Damaged");
            cmbCondition.SelectedIndex = 0;

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Rented");
            cmbStatus.Items.Add("Maintenance");
            cmbStatus.SelectedIndex = 0;
        }

        private void SetupGrid()
        {
            dgvSurfboards.AutoGenerateColumns = true;
            dgvSurfboards.DataSource = null;
        }

        private void BindGrid()
        {
            dgvSurfboards.DataSource = null;
            dgvSurfboards.DataSource = surfboards;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (textBoardID.Text == "")
            {
                MessageBox.Show("Enter Board ID");
                return;
            }

            Surfboard sb = new Surfboard()
            {
                BoardID = textBoardID.Text,
                BoardType = cmbBoardType.Text,
                Size = txtBoardSize.Text,
                Condition = cmbCondition.Text,
                Price = Convert.ToDecimal(txtPrice.Text),
                Status = cmbStatus.Text
            };

            surfboards.Add(sb);
            BindGrid();
            ClearFields();

            MessageBox.Show("Surfboard Added Successfully!");
        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSurfboards.CurrentRow != null)
            {
                int index = dgvSurfboards.CurrentRow.Index;

                surfboards[index].BoardID = textBoardID.Text;
                surfboards[index].BoardType = cmbBoardType.Text;
                surfboards[index].Size = txtBoardSize.Text;
                surfboards[index].Condition = cmbCondition.Text;
                surfboards[index].Price = Convert.ToDecimal(txtPrice.Text);
                surfboards[index].Status = cmbStatus.Text;

                BindGrid();
                ClearFields();

                MessageBox.Show("Updated Successfully!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSurfboards.CurrentRow != null)
            {
                int index = dgvSurfboards.CurrentRow.Index;
                surfboards.RemoveAt(index);

                BindGrid();
                ClearFields();

                MessageBox.Show("Deleted Successfully!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            textBoardID.Clear();
            txtBoardSize.Clear();
            txtPrice.Clear();

            cmbBoardType.SelectedIndex = 0;
            cmbCondition.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

            textBoardID.Focus();
        }

        private void dgvSurfboards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSurfboards.Rows[e.RowIndex];

                textBoardID.Text = row.Cells["BoardID"].Value.ToString();
                cmbBoardType.Text = row.Cells["BoardType"].Value.ToString();
                txtBoardSize.Text = row.Cells["Size"].Value.ToString();
                cmbCondition.Text = row.Cells["Condition"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }

    public class Surfboard
    {
        public string BoardID { get; set; }
        public string BoardType { get; set; }
        public string Size { get; set; }
        public string Condition { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
    }
}