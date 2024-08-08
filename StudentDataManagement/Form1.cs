using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudentDataManagement
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;  // Prevent auto-generation of columns
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Add columns to DataGridView
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Nama", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NIM", HeaderText = "NIM" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Jurusan", HeaderText = "Major" });
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn
            {
                DataPropertyName = "Foto",
                HeaderText = "Photo",
                ImageLayout = DataGridViewImageCellLayout.Zoom  // Adjust image size to fit the cell
            };
            dataGridView1.Columns.Add(imgColumn);
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNama.Text) && !string.IsNullOrEmpty(txtNIM.Text) && !string.IsNullOrEmpty(txtJurusan.Text) && picStudent.Image != null)
            {
                Image foto = picStudent.Image;
                Student student = new Student(txtNama.Text, txtNIM.Text, txtJurusan.Text, foto);
                students.Add(student);
                dataGridView1.DataSource = new BindingList<Student>(students);
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Please fill all fields and select a photo.");
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                picStudent.Image = Image.FromFile(filePath);
                picStudent.Tag = filePath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = textsearchdelete.Text.ToLower();
            var filteredStudents = students.Where(s => s.Nama.ToLower().Contains(searchTerm) || s.NIM.Contains(searchTerm)).ToList();
            dataGridView1.DataSource = new BindingList<Student>(filteredStudents);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string searchTerm = textsearchdelete.Text.ToLower();
            students = students.Where(s => !s.Nama.ToLower().Contains(searchTerm) && !s.NIM.Contains(searchTerm)).ToList();
            dataGridView1.DataSource = new BindingList<Student>(students);
        }

        private void exit_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ClearInputs()
        {
            txtNama.Text = "";
            txtNIM.Text = "";
            txtJurusan.Text = "";
            picStudent.Image = null;
        }
    }
}
