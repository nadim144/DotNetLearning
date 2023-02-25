using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_namespace;

namespace FullTimeEmployee_namespace
{
    class FullTimeEmployee:Employee
    {
        private float salary;
        public FullTimeEmployee(string fname, string lname, string email, float s):base(fname, lname, email)
        {
            this.salary = s;
        }

        public new void printEmployeeDetails()
        {
            Console.WriteLine("FullTimeEmployee base class - printEmployeeDetails()");
            Console.WriteLine("First Name: {0} Last Name: {1} Email: {2} and salary: {3}", firstName, lastName, email, salary);
        }
    }
}
