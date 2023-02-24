using System;

namespace CSharp_StringConcatPlaceHolder
{
    class StringConcatPlaceHolder
    {
        static void Main(string[] args)
        {
            string strName = "";
            Console.WriteLine("Enter your name: ");
            strName = Console.ReadLine();
            Console.WriteLine("Your name is : {0}", strName);
            Console.WriteLine("Your name is + strName");
        }
    }
}
