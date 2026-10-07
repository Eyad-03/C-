using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Sara";
        int age = 24;

        // String Interpolation
        Console.WriteLine($"My name is {name} and I am {age} years old.");

        // Access String Characters using Index
        Console.WriteLine($"First character: {name[0]}");
        Console.WriteLine($"Second character: {name[1]}");
        Console.WriteLine($"Last character: {name[name.Length - 1]}");

        // Special Character \n
        Console.WriteLine("Hello\nWelcome to C#");

        // Special Character \t
        Console.WriteLine("Name\tAge");
        Console.WriteLine($"{name}\t{age}");

        // Special Character "
        Console.WriteLine("She said \"Hello\"");

        Console.WriteLine("She said \\Hello\\");

        Console.WriteLine("She said \'Hello\'");
    }
}