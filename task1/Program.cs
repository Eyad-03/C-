using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 1

            string studentName = "Eyad";
            int age = 20;
            int grde = 90;
            double average = 90.5;
            string gender = "Male";
            bool isActive = true;


            // part 2

            string [] students = { "Eyad", "omar", "Mohammed" };

            Console.WriteLine("students Name is : " + students[0]);
            Console.WriteLine("students Name is : " + students[1]);
            Console.WriteLine("students Name is : " + students[2]);

            Console.WriteLine("Number of Students : " + students.Length);


            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);

            students[0] = "tariq";
            students[1] = "khalid";
            students[2] = "ahmed";

            Console.WriteLine("after modification>");

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);



        }
    }
}
