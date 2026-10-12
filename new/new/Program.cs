using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class Program
    {
        static void Main(string[] args)
        {

            Students student1 = new Students();
            student1.Name = "John";
            student1.Age = 20;
            student1.Grade = "A";
            Console.WriteLine(student1.DisplayInfo());



            Students student2 = new Students("Jane", 22, "B");
            Console.WriteLine(student2.DisplayInfo());

            Students student3 = new Students() { Name = "Bob", Age = 21, Grade = "C" };
            Console.WriteLine(student3.DisplayInfo());

        }
    }

