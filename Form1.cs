using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

            students = handler.LoadStudents();  //we want to read the latest data
            dataGridView1.DataSource = students.Select(s => new { s.StudentId, s.FullName, s.Age, s.Course }).ToList();
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
