using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_4
{
    interface ICustomer_1
    {
        void Print_1();
    }

    interface ICustomer_2 : ICustomer_1
    {
        void Print_2();
    }

    class Customer : ICustomer_2
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

            //ICustomer_1 icust1 = new ICustomer_1(); //Error

            ICustomer_1 icust1 = new Customer();
            icust1.Print_1();


            ICustomer_2 icust2 = new Customer();
            icust2.Print_1();
            icust2.Print_2();
        }
    }
}
