using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Student:Person
    {
        public int Grade { get; set; }

        public int StudentId { get; set; }

        public string DisplaySchoolName()
        {
            return $"School Name: {SchoolName}";
        }

      public Student(string name, int age, int grade, int studentId)
        {
            Name = name;
            Age = age;
            Grade = grade;
            StudentId = studentId;
        }
    }
}
