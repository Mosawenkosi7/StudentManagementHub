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
    }
}
