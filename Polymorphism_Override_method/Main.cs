using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Override_method
{
    class Program
    {
        public static void Main()
        {
            Employee[] emp = new Employee[4];
            emp[0] = new Employee();
            emp[1] = new FullTimeEmployee();
            emp[2] = new PartTimeEmployee();
            emp[3] = new TemporaryEmployee();

            foreach(Employee e in emp)
            {
                e.printFullName();
            }
        }
    }
}
