using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_namespace;

namespace PartTimeEmployee_namespace
{
    class PartTimeEmployee:Employee
    {
        private float hourlyCharge;
        public PartTimeEmployee(string fname, string lname, string email, float charge) : base(fname, lname, email)
        {
            this.hourlyCharge = charge;
        }

        public new void printEmployeeDetails()
        {
            Console.WriteLine("First Name: {0} Last Name: {1} Email: {2} and Hourly charege: {3}", firstName, lastName, email, hourlyCharge);
        }
    }
}
