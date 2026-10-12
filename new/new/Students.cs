using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Students
{

    public string Name;

    public int Age;

    public string Grade;


    public string DisplayInfo()
    {
        return $"Name: {Name}, Age: {Age}, Grade: {Grade}";
    }

   public Students()
    {
        Name = "Unknown";
        Age = 0;
        Grade = "N/A";
    }

    public Students(string name, int age, string grade)
    {
        this.Name = name;
        this.Age = age;
        this.Grade = grade;
    }


}

