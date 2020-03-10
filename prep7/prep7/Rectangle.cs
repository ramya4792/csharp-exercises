using System;
using System.Collections.Generic;
using System.Text;

namespace prep7
{
    public class Rectangle : Shape
    {
        
        public double Length
        {
            get;
            set;
        }

        public double Width
        {
            get;
            set;
        }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
        public override double Area()
        {
            return Length * Width;
        }

        public override double Perimeter()
        {
            return 2 * (Length + Width);
        }
    }
}