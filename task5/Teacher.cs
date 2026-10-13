using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Teacher:Person
    {

        public string Subject { get; set; }

                    
        public Teacher(string name, int age, string subject)
        {
            Name = name;
            Age = age;
            Subject = subject;
            SchoolName = "ABC School"; 
        }

        public string DisplayTeacherInfo()
        {
            return $"Name: {Name}, Age: {Age}, Subject: {Subject}";
        }

    }
}
