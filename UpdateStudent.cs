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
    public partial class UpdateStudent : Form
    {
        List<Student> students = new List<Student>();
        //assuming that we are getting updated data
        DataHandler fh = new DataHandler();

        public UpdateStudent()
        {
            InitializeComponent();
        }


        public void AddDataToList()
        {
            fh.ReadList();
            foreach (string item in fh.rawData)
            {
                string[] splitData = item.Split(',');
                int ageData = int.Parse(splitData[2]);

                students.Add(new Student(splitData[0], splitData[1], ageData, splitData[3]));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row index
                int rowIndex = e.RowIndex;

                // Retrieve the student from the list using the row index
                Student selectedStudent = students[rowIndex];

                // Populate the textboxes with the selected student's data
                StudentId.Text = selectedStudent.StudentId.ToString();
                FullName.Text = selectedStudent.FullName;
                Age.Value = selectedStudent.Age;
                comboBox1.Text = selectedStudent.Course;



            }
        }

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            // Call the method to add data to the students list
            AddDataToList();
            dataGridView1.DataSource = null; // Clear existing data

            if (students.Count > 0)
            {
                // Only bind if there is data in the list
                dataGridView1.DataSource = students; // Bind the students list to the DataGridView
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No data available to display.");
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

            if (rowIndex >= 0)
            {
                // Retrieve the selected student from the list
                Student selectedStudent = students[rowIndex];

                // Update the student's properties with the values from the textboxes
                selectedStudent.StudentId = StudentId.Text; // Assuming StudentId.Text contains the student ID
                selectedStudent.FullName = FullName.Text;
                selectedStudent.Age = (int)Age.Value; // Assuming Age is a numeric input control
                selectedStudent.Course = comboBox1.Text;

            
                // Refresh the DataGridView to show updated data
                //make the datagrid null then save it to 
                dataGridView1.DataSource = null; //the database
                StudentId.Clear();
                FullName.Clear();
                Age.Value = Age.Minimum;
                comboBox1.Text = null;

                fh.UpdateStudentFile(selectedStudent);
                dataGridView1.DataSource = students;

            }
        }
    }


}
