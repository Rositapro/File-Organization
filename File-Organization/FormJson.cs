using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace File_Organization
{
    public partial class FormJson : Form
    {
        private List<Product> products = new List<Product>();
        private string jsonFilePath = "products.json";
        public FormJson()
        {
            InitializeComponent();
            ConfigurarDataGridView();
            CargarDesdeJson();
        }
       
        private void ConfigurarDataGridView()
        {
            dgvStore.ColumnCount = 4;
            dgvStore.Columns[0].Name = "Id";
            dgvStore.Columns[1].Name = "Name";
            dgvStore.Columns[2].Name = "Price";
            dgvStore.Columns[3].Name = "Stock";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            string name = txtName.Text.Trim();
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("The price must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtStock.Text.Trim(), out int stock))
            {
                MessageBox.Show("Stock must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (products.Any(p => p.ID == id))
            {
                MessageBox.Show("The ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            products.Add(new Product { ID = id, Name = name, Price = price, Stock = stock });
            UpdateDataGridView();
            txtID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select JSON file";
                openFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    jsonFilePath = openFileDialog.FileName;
                    CargarDesdeJson();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchId = txtID.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchId))
            {
                MessageBox.Show("Enter an ID to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = products.FirstOrDefault(p => p.ID == searchId);
            if (product != null)
            {
                MessageBox.Show($"Product found:\n\nID: {product.ID}\nName: {product.Name}\nPrice: {product.Price}\nStock: {product.Stock}", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string deleteId = txtID.Text.Trim();
            if (string.IsNullOrWhiteSpace(deleteId))
            {
                MessageBox.Show("Enter an ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var producto = products.FirstOrDefault(p => p.ID == deleteId);
            if (producto != null)
            {
                products.Remove(producto);
                UpdateDataGridView();
                MessageBox.Show("Product disposed correctly.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save JSON file";
                saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
                saveFileDialog.FileName = "products.json"; // Nombre sugerido

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    jsonFilePath = saveFileDialog.FileName;
                    GuardarEnJson();
                }
            }
        }
        private void GuardarEnJson()
        {
            string json = JsonSerializer.Serialize(products, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(jsonFilePath, json);

            MessageBox.Show($"Data saved in:\n{jsonFilePath}", "Saved Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abre el explorador de archivos en la ubicación del archivo guardado
            string folderPath = Path.GetDirectoryName(jsonFilePath);
            System.Diagnostics.Process.Start("explorer.exe", folderPath);
        }

        private void CargarDesdeJson()
        {
            if (!File.Exists(jsonFilePath))
                return;

            string json = File.ReadAllText(jsonFilePath);
            products = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dgvStore.Rows.Clear();
            foreach (var prod in products)
            {
                dgvStore.Rows.Add(prod.ID, prod.Name, prod.Price, prod.Stock);
            }
        }
    }

}