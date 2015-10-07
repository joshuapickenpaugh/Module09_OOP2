//Joshua Pickenpaugh, IN2017, Adv.C#.
//October 7th, 2015

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from MAIN.");

            //Object instantiation:
            Shape s = new Shape();
            s.HelloShape();

            Console.ReadKey();
        }
    }

    class Shape
    {
        public Shape()
        {

        }

        public void HelloShape()
        {
            Console.WriteLine();
            Console.WriteLine("Hello from HelloShape method");
            Console.WriteLine();
        }
    }
}