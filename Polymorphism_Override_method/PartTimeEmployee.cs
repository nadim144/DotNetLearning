using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Override_method
{
    class PartTimeEmployee:Employee
    {
        public override void printFullName()
        {
            Console.WriteLine("PartTimeEmployee Drived class printFullName()");
        }
    }
}
