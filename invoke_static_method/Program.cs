using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoke_static_method
{
    class Program
    {
        public static void Even_number()
        {
            Console.WriteLine("This is static method invoked ...");

        }
        static void Main(string[] args)
        {
            Program.Even_number();
        }
    }
}
