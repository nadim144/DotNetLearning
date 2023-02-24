using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_namespace
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public Employee()
        {
            //Deafaul Comnstructor
        }

        public Employee(string fname, string lname, string email)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.email = email;
        }
        public void printEmployeeDetails()
        {
            Console.WriteLine("First Name: {0} Last Name: {1} and Email: {2}", firstName, lastName, email);
        }
    }
}
