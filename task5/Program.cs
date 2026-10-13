using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            // Console.WriteLine(person.SchoolName); // error because SchoolName is protected and cannot be accessed from here
            // Console.WriteLine(person._internalCode); // error because _internalCode is private and cannot be accessed from here


            Student student1 = new Student("Wadea ", 20, 85, 12345);
            Student student2 = new Student("Eyad ", 30, 95, 12355);
            Teacher teacher = new Teacher("Mr. Abdallah", 40, "Mathematics");

            Console.WriteLine(student1.DisplayInfo());
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(student2.DisplayInfo());
            Console.WriteLine("---------------------------------------------------------");

            Console.WriteLine(teacher.DisplayInfo());
            Console.WriteLine("---------------------------------------------------------");

            SchoolReport report1 = new SchoolReport("Student Report");
            Console.WriteLine(report1.DisplayReportTitle());

        }
    }
}
