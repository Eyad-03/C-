using System;
using test;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        student.Name = "Ahmad"; // set
        student.Age = 22;       // set

        Console.WriteLine(student.Name); // get


        //  Auto Property


        /*
        Student studentAuto = new Student
        {
            Name = "Ahmad",
            Age = 22
        };

        Console.WriteLine(studentAuto.Name);
        Console.WriteLine(studentAuto.Age);
        */


        // Access Modifiers

        Employee emp = new Employee();

        Console.WriteLine(emp.Name);       // ✅ مسموح
        // Console.WriteLine(emp.Salary);  // ❌ خطأ
        // Console.WriteLine(emp.Department); // ❌ خطأ



    }
}