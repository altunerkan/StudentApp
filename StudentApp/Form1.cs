using StudentApp.Models;
using System.Runtime.InteropServices;

namespace StudentApp
{
    public partial class Form1 : Form
    {

        List<Student> students = new List<Student>();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void RefreshGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
            
                
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Lütfen Yaþ Deðerini Doðru Giriniz");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ýsim Alaný Boþ Býrakýlamaz");
                return;
            }

            students.Add(new Student
            {
                Name = txtName.Text,
                Age = age,
                Id = students.Count + 1
            });

            RefreshGrid();

            txtName.Clear();
            txtAge.Clear();
            txtName.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                Student selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;

                students.Remove(selectedStudent);


            }
            else
            {
                MessageBox.Show("Herhangi Bir Öðe Seçili Deðil");
                return;
            }

                RefreshGrid();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
