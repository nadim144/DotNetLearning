using System;

namespace ParseAndTryParse
{
    class clsParseAndTryParse
    {
        static void Main(string[] args)
        {
            string strvalue1 = "100";
            int ivalue1 = int.Parse(strvalue1);
            Console.WriteLine(ivalue1);

            //string strvalue2 = "100G";
            //int ivalue2 = int.Parse(strvalue2);
            //Console.WriteLine(ivalue2);

            string strvalue3 = "100";
            int result3 = 0;
            int.TryParse(strvalue3, out result3);
            Console.WriteLine(result3);

            string strvalue4 = "100H";
            int result4 = 0;
            int.TryParse(strvalue4, out result4);
            Console.WriteLine(result4);

        }
    }
}
