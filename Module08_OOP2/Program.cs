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

            Ball b = new Ball();
            b.Weight = 2.31;
            b.Bounce();

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
            Console.WriteLine("Hello from HelloShape method");
        }
    }

    class Ball
    {
        //"the nouns"...:
        private string shapeBall;
        private string color;
        private double weight;

        //Now avaiable to other classes..."Encapsulation"...Refactor-->Encapsulate Field:
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //"the verbs"...:
        public void Bounce()
        { 
            Console.WriteLine("I am bouncing..."); 
        }

        public void Swing()
        {
            Console.WriteLine("I am swinging...");
        }
    }
}