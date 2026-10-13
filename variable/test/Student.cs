using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be between 0 and 120.");
                }
            }
        }
    }
}
