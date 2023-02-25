using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_5
{
    interface I1
    {
        void Print();
    }
    interface I2
    {
        void Print();
    }

    class Customer : I1, I2
    {
        void I1.Print()
        {
            Console.WriteLine("Print() - I1");
        }
        void I2.Print()
        {
            Console.WriteLine("Print() - I2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            ((I1)c).Print();
            ((I2)c).Print();

            I1 i1 = new Customer();
            i1.Print();

            I2 i2 = new Customer();
            i2.Print();

        }
    }
}
