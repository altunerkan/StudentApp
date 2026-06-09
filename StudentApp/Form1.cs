using StudentApp.Models;
using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentApp
{
    public partial class Form1 : Form
    {

        
        SQLiteConnection connection = new SQLiteConnection("Data Source=C:/Users/erkna/OneDrive/Desktop/C#/StudentApp/StudentApp/Database/students.db;Version=3");
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

        private void AddStudentToDatabase(string name,int age)
        {            
            connection.Open();
            string query = @"Insert Into Students (Name,Age) VALUES(@name, @age)";
            SQLiteCommand command = new SQLiteCommand(query,connection);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@age", age);
            command.ExecuteNonQuery();
            connection.Close();
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

            AddStudentToDatabase(txtName.Text, age);

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
            Student selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
            txtName.Text = selectedStudent.Name;
            txtAge.Text = Convert.ToString(selectedStudent.Age);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Lütfen Yaþ Deðerini Doðru Giriniz");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ýsim Alaný Boþ Býrakýlamaz");
                return;
            }

            else
            {
                Student selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
                selectedStudent.Name = txtName.Text;
                selectedStudent.Age = Convert.ToInt32(txtAge.Text);
                txtName.Clear();
                txtAge.Clear();
                txtName.Focus();
                RefreshGrid();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStudents.DataSource = students;
            List<Student> src = new List<Student>();
            foreach(Student student in students)
            {
                if (student.Name.Contains(txtSearch.Text))
                {
                    src.Add(student);
                }               
            }

            if (src.Count > 0) 
            {
                dgvStudents.DataSource = src;
            }
            else
            {
                MessageBox.Show("Aradýðýn Deðerle Eþleþen Öðe Bulunamadý");
                RefreshGrid();
            }            
        }
    }
}
