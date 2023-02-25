using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_3
{
    interface ICustomer_1
    {
        void Print_1();
    }
    interface ICustomer_2
    {
        void Print_2();
    }

    class Customer : ICustomer_1, ICustomer_2
    {
        public void Print_1()
        {
            Console.WriteLine("Print_1() from ICustomer_1");
        }

        public void Print_2()
        {
            Console.WriteLine("Print_2() from ICustomer_2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Print_1();
            c.Print_2();
        }
    }
}
