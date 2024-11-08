using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementHub
{
    public partial class Form1 : Form
    {
        private DataHandler handler;
        private List<Student> students;
        public Form1()
        {
            InitializeComponent();
            handler = new DataHandler();
            LoadStudents();
        }
        private void LoadStudents()//for viewing data
        {

            students = handler.LoadStudents();
            dataGridView1.DataSource = students.Select(s => new { s.StudentId, s.FullName, s.Age, s.Course }).ToList();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = dataGridView1.SelectedRows[0];
                StudentIdTxtBox.Text = row.Cells["StudentID"].Value.ToString();
                NamesTxtBox.Text = row.Cells["Name"].Value.ToString();
                Age.Text = row.Cells["Age"].Value.ToString();
                CourseList.Text = row.Cells["Course"].Value.ToString();
            }
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
