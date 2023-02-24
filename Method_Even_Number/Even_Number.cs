using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Even_Number
{
    class Even_Number
    {
        public void Display_Even_Number(sbyte input)
        {
            for(sbyte i = 2; i <= input; )
            {
                Console.WriteLine(i.ToString());
                i = (sbyte)((sbyte)i + 2);
            }
        }
        static void Main(string[] args)
        {
            Even_Number p = new Even_Number();
            p.Display_Even_Number(20);
        }
    }
}
