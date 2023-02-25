using System;

namespace Nullabletype
{
    class clsNullabletype
    {
        static void Main(string[] args)
        {
            string FName = "";
            string LName = "";
            bool? Major = false;

            Console.WriteLine("Enter your first Name:");
            FName = Console.ReadLine();
            Console.WriteLine("Enter your last Name: ");
            LName = Console.ReadLine();
            Console.WriteLine("Are you Minor or Major ?");
            var temp = Console.ReadLine();
            Major = Convert.ToBoolean(temp);

            Console.WriteLine("Your name is {0} {1}", FName, LName);
            Console.WriteLine("Are you major? :");
        }
    }
}
