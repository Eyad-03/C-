using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] students = {"Eyad", "Omar", "Mohammed","Wadea","Saif"};

            void PrintStudents()
            {

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}: {students[i]}");
            }

            }



            int[] grades = { 85, 90, 78, 92, 88 };

            void printGrades()
            {

            foreach(var grade in grades)
            {
                Console.WriteLine($"Grade: {grade}");
            }

            }


            void searchStudents()
            {
                Console.WriteLine("Enter the name of the student to search:");
                string searchStudent = Console.ReadLine();
                int j = 0;

            while(j<students.Length)
            {
               
                    if(students[j] == searchStudent)
                    {
                        Console.WriteLine($"Found student: {students[j]}");
                        break;
                    }

                j++;
                
            }

            

            }

            void RangeGrade()
            {

            Console.WriteLine("Enter a grade between 0 and 100:");
            int userGrade = Convert.ToInt32(Console.ReadLine());

            if(userGrade>=90 && userGrade<=100)
            {
                Console.WriteLine("Excellent");
            }

            else if (userGrade >= 80 && userGrade <= 89)
            {
                Console.WriteLine("Very Good");
            }

            else if(userGrade >= 70 && userGrade <= 79)
            {
                Console.WriteLine("Good");
            }

            else if (userGrade >=60 && userGrade<=69)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Fail");
            }

            }

            int choice = 0;

            do
            {

                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Print Students");
                Console.WriteLine("2. Print Grades");
                Console.WriteLine("3. Search Students");
                Console.WriteLine("4. Range Grade");
                Console.WriteLine("5. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintStudents();
                        break;

                    case 2:
                        printGrades();
                        break;

                    case 3:
                        searchStudents();
                        break;

                    case 4:
                        RangeGrade();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }


            } while (choice != 5);



        }
    }
}
