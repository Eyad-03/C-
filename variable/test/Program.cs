
using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();

        // Method Overloading
        person.GetName("Eyad");
        person.GetName(1, "Eyad");
        person.GetName("Eyad", 1);

        // Inheritance
        Info info = new Info();
        info.GetName("Eyad", 1, "Male", "123 Main St", "+962-795422");


    }
}

    public class Person
    {
        public int Id;
        public string Name;

        // Overload 1
        public void GetName(string name)
        {
            Console.WriteLine("Name: " + name);
        }
    5
        // Overload 2
        public void GetName(int id, string name)
        {
            Console.WriteLine("Name: " + name + ", Id: " + id);
        }

        // Overload 3
        public void GetName(string name, int id)
        {
            Console.WriteLine("Name: " + name + ", Id: " + id);
        }
    }

    public class Info : Person
    {
        public string Gender;
        public string Address;
        public string Phone;


    // Overload 4
    public void GetName(string name,int id,string gender,string address, string phone)
        {
            Console.WriteLine(
                "Name: " + name +
                ", Id: " + id +
                ", Gender: " + gender +
                ", Address: " + address +
                ", Phone: " + phone
            );
        }

}
