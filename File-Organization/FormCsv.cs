using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Organization
{
    public partial class FormCsv : Form
    {
        public FormCsv()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            txtID.KeyPress += txtNumeric_KeyPress;
            txtPrice.KeyPress += txtNumeric_KeyPress;
            txtStock.KeyPress += txtNumeric_KeyPress;
            txtEdition.KeyPress += txtNumeric_KeyPress;
        }
        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ConfigurarDataGridView()
        {
            dgvBook.ColumnCount = 5;
            dgvBook.Columns[0].Name = "Id";
            dgvBook.Columns[1].Name = "Name";
            dgvBook.Columns[2].Name = "Price";
            dgvBook.Columns[3].Name = "Stock";
            dgvBook.Columns[4].Name = "Edition";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newId = txtID.Text.Trim();
            foreach (DataGridViewRow row in dgvBook.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == newId)
                {
                    MessageBox.Show("The ID already exists. Enter a unique ID. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }
            dgvBook.Rows.Add(txtID.Text, txtName.Text, txtPrice.Text, txtStock.Text, txtEdition.Text);
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            txtEdition.Clear();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    dgvBook.Rows.Clear();
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] rowData = line.Split(',');
                            dgvBook.Rows.Add(rowData);
                        }
                    }
                    MessageBox.Show("Data loaded successfully.", "Upload CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtID.Text;
            foreach (DataGridViewRow row in dgvBook.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == searchId)
                {
                    row.Selected = true;
                    MessageBox.Show("Found book.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("Found not book.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteId = txtID.Text;
            bool found = false;
            foreach (DataGridViewRow row in dgvBook.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == deleteId)
                {
                    dgvBook.Rows.Remove(row);
                    found = true;
                    break; 
                }
            }

            if (found)
            {
                MessageBox.Show("Successfully deleted book.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveCsv_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", FileName = "books.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (DataGridViewRow row in dgvBook.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string[] rowData = new string[dgvBook.ColumnCount];
                                for (int i = 0; i < dgvBook.ColumnCount; i++)
                                {
                                    rowData[i] = row.Cells[i].Value?.ToString() ?? "";
                                }
                                sw.WriteLine(string.Join(",", rowData));
                            }
                        }
                    }
                    MessageBox.Show("Data saved in CSV successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
