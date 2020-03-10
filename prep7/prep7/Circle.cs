using System;
using System.Collections.Generic;
using System.Text;

namespace prep7
{
    public class Circle : Shape
    {
        const double pi = Math.PI;

        public double Radius
        {
            get;
            set;
        }

        public  Circle(double radius)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return pi * Radius * Radius;
        }

        public override double Perimeter()
        {
            return 2 * pi * Radius; 
        }
    }
}