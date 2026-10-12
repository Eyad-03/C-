using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string Name;

        public int Age;

        public double Grade;


        public string DisplayInfo()
        {
            return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
        }

        public Student()
        {

        }
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }


    }
}
