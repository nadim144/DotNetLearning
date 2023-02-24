using System;

namespace ConvertClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 1234567891011121314151618.8889f;
            int i = (int)f;
            Console.WriteLine(i);

            int ii = Convert.ToInt32(f);
            Console.WriteLine(ii);
        }
    }
}
