using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Constructor
{
    class Circle
    {
        private static float pi;
        private Int32 radius;

        static Circle() //Static Construictor
        { // it get call only one time irrespective of how many object created. 
            pi = 3.147f;
        }
        public Circle():this(0)
        {

        }

        public Circle(Int32 _radius)
        {
            this.radius = _radius;
        }

        public float CalculateArea()
        {
            return pi * radius * radius;
        }
    }

    class program
    {
        public static void Main()
        {
            Circle C1 = new Circle();
            Console.WriteLine(C1.CalculateArea());

            Circle C2 = new Circle(10);
            Console.WriteLine(C2.CalculateArea());
        }
    }
}
