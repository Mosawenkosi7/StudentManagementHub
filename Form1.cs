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
        // Declare a flag to track if AddDataToList has been executed
        private bool isAddDataToListExecuted = false;

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

        public void AddDataToList()
        {
            handler.ReadList();
            foreach (string item in handler.rawData)
            {
                string[] splitData = item.Split(',');
                int ageData = int.Parse(splitData[2]);

                students.Add(new Student(splitData[0], splitData[1], ageData, splitData[3]));
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                StudentId = StudentIdTxtBox.Text,
                FullName = NamesTxtBox.Text,
                Age = Convert.ToInt32(Age.Value), // Assuming Age is valid
                Course = Course.Text
            };

            //Here we check if all text are entered
            if (!string.IsNullOrWhiteSpace(student.StudentId.ToString()) &&
                !string.IsNullOrWhiteSpace(student.FullName) &&
                student.Age > 0 &&
                !string.IsNullOrWhiteSpace(student.Course))
            {
                //Here i want to make sure that the text file is executed once
                //reason that it will make duplicates of the text file whenever the 
                //add button is clicked 
                if (!isAddDataToListExecuted)
                {
                    AddDataToList(); //this is where we display the list only once
                    isAddDataToListExecuted = true;
                }



                students.Add(student); //add the student  to the list that will be displayed when button is clicked

                handler.WriteFile(student.StudentId, student.FullName, student.Age, student.Course); //update the student file


                //clear the fields once the student is added
                StudentIdTxtBox.Clear();
                NamesTxtBox.Clear();
                Age.Value = Age.Minimum;
                Course.SelectedIndex = -1;

                // Display all the results in the DataGridView
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = students;


                //make the added text field blue
                int lastIndex = students.Count - 1;
                dataGridView1.Rows[lastIndex].Selected = true;
                dataGridView1.Rows[lastIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("All text fields are required");
            }
        }
    }
}
