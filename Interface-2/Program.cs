using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_2
{
    interface ICustomer
    {
        void Print();
    }

    class Customer : ICustomer
    {
        public void Print()
        {
            Console.WriteLine("Print method from Customer class derived from ICustomer.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Print();
        }
    }
}
