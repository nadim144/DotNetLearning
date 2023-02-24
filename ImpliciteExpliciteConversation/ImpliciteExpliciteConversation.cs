using System;

namespace ImpliciteExpliciteConversation
{
    class clsImpliciteExpliciteConversation
    {
        static void Main(string[] args)
        {
            int i = 10;
            float f = (float)i;
            Console.WriteLine(f);

            f = 1234.456f;
            i = (int)f;
            Console.WriteLine(i);
        }
    }
}
