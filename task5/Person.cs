using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Person
    {

        public string Name { get; set; }

        public int Age { get; set; }    

        protected string SchoolName { get; set; }

        private string _internalCode;

        // i can access the private field _internalCode within the Person class only ,
        // because it is private and not accessible from outside the class or derived classes.

        public string DisplayInfo()
        {
            return $"Name: {Name}, Age: {Age}";
        }



    }
}
