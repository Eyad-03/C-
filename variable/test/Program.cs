
using System;

class Program
{
    static void Main(string[] args)
    {





    }

}


class Employee
{

    public string name;
    public int age; 

     public Employee(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

}

class Manager : Employee
{
    public string department;

    Manager(string name, int age, string department):base(name, age)
    {
        this.department = department;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Department: {department}");
    }
}


