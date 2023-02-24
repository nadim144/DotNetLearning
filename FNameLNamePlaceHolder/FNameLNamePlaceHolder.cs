using System;

namespace nsp_FNameLNamePlaceHolder
{
    class FNameLNamePlaceHolder
    {
        static void Main(string[] args)
        {
            string FName = "";
            string LName = "";

            Console.WriteLine("Enter First Name = ");
            FName = Console.ReadLine();

            Console.WriteLine("Enter Last Name = ");
            LName = Console.ReadLine();

            Console.WriteLine("{0} {1}", FName, LName);
        }
    }
}
