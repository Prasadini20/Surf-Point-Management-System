using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace surf_Board
{
    public partial class Form1 : Form
    {
        List<Surfboard> surfboards = new List<Surfboard>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Board Type
            cmbBoardType.Items.AddRange(new string[]
            {
                "Shortboard",
                "Longboard",
                "Funboard",
                "Fishboard",
                "Softboard"
            });

            cmbCondition.Items.AddRange(new string[]
            {
                "Good",
                "Fair",
                "Damaged"
            });

            cmbStatus.Items.AddRange(new string[]
           {
                "Available",
                "Rented",
                "Maintenance"
           });

            cmbSearch.Items.AddRange(new string[]
            {
                "Board Type",
                "Condition",
                "Status"
            });
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoardID.Text == "" ||
                cmbBoardType.Text == "" ||
                txtSize.Text == "" ||
                cmbCondition.Text == "" ||
                txtPrice.Text == "" ||
                cmbStatus.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Surfboard board = new Surfboard();

            board.BoardID = txtBoardID.Text;
            board.BoardType = cmbBoardType.Text;
            board.Size = txtSize.Text;
            board.Condition = cmbCondition.Text;
            board.PricePerHour = decimal.Parse(txtPrice.Text);
            board.Status = cmbStatus.Text;

            surfboards.Add(board);

            RefreshGrid();

            MessageBox.Show("Surfboard Added Successfully.");

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (Surfboard board in surfboards)
            {
                if (board.BoardID == txtBoardID.Text)
                {
                    board.BoardType = cmbBoardType.Text;
                    board.Size = txtSize.Text;
                    board.Condition = cmbCondition.Text;
                    board.PricePerHour = decimal.Parse(txtPrice.Text);
                    board.Status = cmbStatus.Text;

                    RefreshGrid();

                    MessageBox.Show("Surfboard Updated Successfully.");

                    ClearFields();

                    return;
                }
            }

            MessageBox.Show("Board ID not found.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Surfboard boardToRemove = null;

            foreach (Surfboard board in surfboards)
            {
                if (board.BoardID == txtBoardID.Text)
                {
                    boardToRemove = board;
                    break;
                }
            }

            if (boardToRemove != null)
            {
                surfboards.Remove(boardToRemove);

                RefreshGrid();

                MessageBox.Show("Surfboard Deleted Successfully.");

                ClearFields();
            }
            else
            {
                MessageBox.Show("Board ID not found.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            var filteredList = surfboards.Where(b =>
                b.BoardType.ToLower().Contains(searchText) ||
                b.Condition.ToLower().Contains(searchText) ||
                b.Status.ToLower().Contains(searchText))
                .ToList();

            dgvBoards.DataSource = null;
            dgvBoards.DataSource = filteredList;
        }

        private void dgvBoards_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBoards.Rows[e.RowIndex];

                txtBoardID.Text = row.Cells[0].Value.ToString();
                cmbBoardType.Text = row.Cells[1].Value.ToString();
                txtSize.Text = row.Cells[2].Value.ToString();
                cmbCondition.Text = row.Cells[3].Value.ToString();
                txtPrice.Text = row.Cells[4].Value.ToString();
                cmbStatus.Text = row.Cells[5].Value.ToString();
            }
        }

        private void RefreshGrid()
        {
            dgvBoards.DataSource = null;
            dgvBoards.DataSource = surfboards;
        }

        private void ClearFields()
        {
            txtBoardID.Clear();
            txtSize.Clear();
            txtPrice.Clear();
            txtSearch.Clear();

            cmbBoardType.SelectedIndex = -1;
            cmbCondition.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            cmbSearch.SelectedIndex = -1;

            txtBoardID.Focus();
        }
        
    }
}
    