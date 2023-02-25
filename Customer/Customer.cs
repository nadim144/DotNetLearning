using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private sbyte age;

        public Customer():this("No first Name provided", "No Second Name provided", 0)
        {

        }

        public Customer(string fName, string lName, sbyte age) 
        {
            this.firstName = fName;
            this.lastName = lName;
            this.age = age;
        }

        public void print_details()
        {
            Console.WriteLine("Details : {0} {1} {2}", firstName, lastName, age);
        }

        ~Customer()
        {

        }
    }
    class Program
    {
        public static void Main()
        {
            Customer cust1 = new Customer();
            cust1.print_details();
            Customer cust2 = new Customer("Nadim", "Ahmad", 33);
            cust2.print_details();
        }
    }
}

