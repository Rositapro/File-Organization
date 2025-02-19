using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace File_Organization
{
    public partial class FormXml : Form
    {
        private string carpetaDestino = Path.Combine(Application.StartupPath, "StudentData");
        private string? archivoXml;
        private List<Student> student = new List<Student>();
        public FormXml()
        {
            InitializeComponent();
            ConfigurarRutas();
            ConfigurarDataGridView();
            ConfigurarComboBox();
        }
        private void ConfigurarRutas()
        {
            archivoXml = Path.Combine(carpetaDestino, "student.xml");
        }
        private void ConfigurarDataGridView()
        {
            dgvStudent.ColumnCount = 4;
            dgvStudent.Columns[0].Name = "ID";
            dgvStudent.Columns[1].Name = "Name";
            dgvStudent.Columns[2].Name = "Career";
            dgvStudent.Columns[3].Name = "Semester";
        }
        private void ConfigurarComboBox()
        {
            cmbCareer.Items.AddRange(new string[]
            {
                "Informatica", "Industrial", "Mecanica", "Energias renovables", "Gestion empresarial", "Electronica"
            });

            cmbCareer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtCareerID.Text.Trim();
            string name = txtName.Text.Trim();
            string career = cmbCareer.SelectedItem?.ToString();
            string semester = txtSemester.Text.Trim();

            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name) ||string.IsNullOrWhiteSpace(career) || string.IsNullOrWhiteSpace(semester))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(id, @"^[EIGM]\d{3}$"))
            {
                MessageBox.Show("The ID must begin with E, I, G or M followed by three numbers (Example: E123).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (student.Any(stud => stud.CareerId == id))
            {
                MessageBox.Show("The ID already exists. Enter a unique ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (name.Any(char.IsDigit)) 
            {
                MessageBox.Show("The name cannot contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (career.Any(char.IsDigit))
            {
                MessageBox.Show("Race cannot contain numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(semester, out int semesterNumber) || semester.Length != 1 || semesterNumber < 1 || semesterNumber > 9)
            {
                MessageBox.Show("Semester can only contain a number between 1 and 9", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (id[0] != career[0])
            {
                MessageBox.Show($"The first letter of the ID ({id[0]}) must match the first letter of the race ({career[0]}).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            student.Add(new Student { CareerId = id, Name = name,Career = career, Semester = semesterNumber });

            UpdateDataGridView();
            Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string destinationFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StudentData");

                // Asegurar que la carpeta de destino existe antes de abrir el diálogo
                if (!Directory.Exists(destinationFolder))
                {
                    Directory.CreateDirectory(destinationFolder);
                }

                openFileDialog.Title = "Select student file";
                openFileDialog.Filter = "Files XML (*.xml)|*.xml";
                openFileDialog.Multiselect = false;
                openFileDialog.InitialDirectory = destinationFolder; // Establecer la carpeta inicial

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    string extension = Path.GetExtension(selectedFile).ToLower();
                    bool datosCargados = false;

                    if (extension == ".xml")
                    {
                        datosCargados = CargarDesdeXml(selectedFile);
                    }
                    else
                    {
                        MessageBox.Show("Unsupported file format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (datosCargados)
                    {
                        UpdateDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("The selected file is empty or does not contain valid data.", "Wearning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string idSearched = txtCareerID.Text;
            if (string.IsNullOrWhiteSpace(idSearched))
            {
                MessageBox.Show("Enter an ID to search.");
                return;
            }

            var studentFound = student.FirstOrDefault(stud => stud.CareerId == idSearched);
            if (studentFound != null)
            {
                MessageBox.Show("Student found: " + studentFound.CareerId + " " + studentFound.Name + " " + studentFound.Career + " " + studentFound.Semester);
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = txtCareerID.Text.Trim();
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("You must enter an ID to delete the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var studentToRemove = student.FirstOrDefault(emp => emp.CareerId == id);
            if (studentToRemove != null)
            {
                student.Remove(studentToRemove);
                MessageBox.Show("Employee successfully removed.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDataGridView();
                Clear();
            }
            else
            {
                MessageBox.Show("An employee with that ID was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            SaveInXml();
            OpenFolder();
        }
        private void UpdateDataGridView()
        {
            dgvStudent.Rows.Clear();
            foreach (var stud in student)
            {
                dgvStudent.Rows.Add(stud.CareerId, stud.Name,stud.Career, stud.Semester);
            }
        }
        private void SaveInXml()
        {
            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (TextWriter writer = new StreamWriter(archivoXml))
            {
                serializer.Serialize(writer, student);
            }
            MessageBox.Show($"Data saved in XML\nUbicación: {archivoXml}");
        }
        private bool CargarDesdeXml(string archivo)
        {
            if (!File.Exists(archivo) || new FileInfo(archivo).Length == 0)
                return false;

            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            using (TextReader reader = new StreamReader(archivo))
            {
                student = (List<Student>)serializer.Deserialize(reader);
            }

            return student.Count > 0;
        }
        private void OpenFolder()
        {
            Process.Start("explorer.exe", carpetaDestino);
        }
        private void Clear()
        {
            txtCareerID.Clear();
            txtName.Clear();
            cmbCareer.SelectedIndex = -1;
            txtSemester.Clear();
        }
    }
}
