using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementHub
{
    internal class DataHandler
    {
        //Reference text file
        string studentFile = "studentFile.txt";
        string summaryFile = "summary.txt";

        public List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();
            if (File.Exists(studentFile))
            {
                var lines = File.ReadAllLines(studentFile);

                foreach (var line in lines)
                {
                    var data = line.Split(',');

                    // Ensure the line has exactly 4 parts: StudentID, Name, Age, and Course
                    if (data.Length == 4)
                    {
                        try
                        {
                            // Try parsing the StudentID and Age. If invalid, skip this line.

                            int age = int.Parse(data[2]);

                            // Add the student to the list
                            students.Add(new Student
                            {
                                StudentId = data[0],
                                FullName = data[1],
                                Age = age,
                                Course = data[3]
                            });
                        }
                        catch (FormatException ex)
                        {
                            // Handle parsing errors (e.g., invalid StudentID or Age)
                            MessageBox.Show($"Error parsing line: {line}. Details: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            // Catch any other general errors
                            MessageBox.Show($"An unexpected error occurred while processing the line: {line}. Details: {ex.Message}");
                        }
                    }
                    else
                    {
                        // Handle lines with incorrect format (less than 4 fields)
                        MessageBox.Show($"Skipping invalid line: {line} (should contain 4 comma-separated values).");
                    }
                }
            }

            return students;
        }
        // Save all students to the file
        public void SaveStudents(List<Student> students)
        {
            File.WriteAllLines(studentFile, students.Select(s => s.ToString()));
        }


        //Adding functionality
        //a list that will store all the information from the text file, line by line 
        public List<string> rawData = new List<string>();

        //create a method that will read the list and store the data into a list 
        public void ReadList()
        {
            using (StreamReader read = new StreamReader(studentFile))
            {
                //read each line and add it to a list 
                string line;
                while ((line = read.ReadLine()) != null)
                {
                    rawData.Add(line); //all the text from student text file are added row by row 
                }
            }
        }

        //create a method that will update the student text file when the button is clicked
        public void WriteFile(string studentId, string name, int age, string course)
        {
            using (FileStream fs = new FileStream(studentFile, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    string studentData = $"{studentId},{name},{age},{course}";
                    writer.Write(studentData);
                }
            }

        }

    }
}
