using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{

    class Manager : Employee
    {
        public void ShowDepartment()
        {
            Console.WriteLine(Name);       // ✅ public
                                           // Console.WriteLine(Salary);  // ❌ private
            Console.WriteLine(Department); // ✅ protected
        }
    }

}
