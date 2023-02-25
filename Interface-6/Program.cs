using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_6
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
        public void Print()
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
            c.Print();          // Default Implementation call
            ((I2)c).Print();    // Interface call.

            I1 i1 = new Customer();
            i1.Print();

            I2 i2 = new Customer();
            i2.Print();
        }
    }
}
