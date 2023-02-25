using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Override_method
{
    class Employee
    {
        //public string firstName;
        //public string lastName;

        public virtual void printFullName()
        {
            Console.WriteLine("Employee Base class printFullName()");
        }
    }
}
