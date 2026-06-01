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
            dgvStudents.DataSource=students;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {  
            if(!int.TryParse(txtAge.Text, out int age)) return;
            if (string.IsNullOrWhiteSpace(txtName.Text)) return;

            students.Add(new Student
            {
                Name = txtName.Text,
                Age = age,
                Id = students.Count + 1
            });
            

            RefreshGrid();
        }
    }
}
