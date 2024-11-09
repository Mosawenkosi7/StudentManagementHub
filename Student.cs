using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementHub
{
    internal class Student
    {
        public string StudentId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student() { }

        public Student(string studentId, string fullName, int age, string course)
        {
            StudentId = studentId;
            FullName = fullName;
            Age = age;
            Course = course;
        }
    }
}
