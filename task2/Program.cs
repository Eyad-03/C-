using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your average: ");
            double average = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your gender: ");
            string gender = Console.ReadLine();

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Welcome {userName}");
            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Gender: {gender}");

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Original Name: {userName}");
            Console.WriteLine($"Uppercase: {userName.ToUpper()}");
            Console.WriteLine($"Lowercase: {userName.ToLower()}");
            Console.WriteLine($"First Character: {userName[0]}");

            Console.WriteLine("---------------------------------------------------");
            double newAverage = average;
            Console.WriteLine($"Original Average: {average}");
            Console.WriteLine($"Bonus Marks: 5");
            Console.WriteLine($"New Average: {newAverage += 5}");

            Console.WriteLine("---------------------------------------------------");
            if (newAverage >= 50)
            {
                Console.WriteLine("Passed: True");
            }

            else
            {
                Console.WriteLine("Failed: True");
            }

            if (age >= 18)
            {
                Console.WriteLine("Adult : True");
            }
            else
            {
                Console.WriteLine("Adult : False");
            }

        }
    }
}
