using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FullTimeEmployee_namespace;
using PartTimeEmployee_namespace;
using Employee_namespace;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee("Nadim", "Ahmad", "ahmad@gmail.com", 3300000.45f);
            fte.printEmployeeDetails();

            Employee e = new PartTimeEmployee("XYZ", "PQR", "ABC@gmail.com", 8);
            e.printEmployeeDetails();
        }
    }
}
