using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student();
            student1.Name = "John";
            student1.Age = 20;
            student1.Grade = 90.5;
            Console.WriteLine(student1.DisplayInfo());
            Console.WriteLine("-----------------------------------------------------------");


            Student student2 = new Student();
            student2.Name = "Jane";
            student2.Age = 22;
            student2.Grade = 85.0;
            Console.WriteLine(student2.DisplayInfo());
            Console.WriteLine("-----------------------------------------------------------");

            Student student3 = new Student();
            student3.Name = "Bob";
            student3.Age = 21;
            student3.Grade = 88.5;
            Console.WriteLine(student3.DisplayInfo());
            Console.WriteLine("-----------------------------------------------------------");


            Student student4 = new Student("eyad", 23, 92.0);
            Console.WriteLine(student4.DisplayInfo());
            Console.WriteLine("-----------------------------------------------------------");

            Student student5 = new Student("ahmad", 24, 87.5);
            Console.WriteLine(student5.DisplayInfo());
            Console.WriteLine("-----------------------------------------------------------");

            Student student6 = new Student("ali", 25, 91.0);
            Console.WriteLine(student6.DisplayInfo());
            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}
