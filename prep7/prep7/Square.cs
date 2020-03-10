using System;
using System.Collections.Generic;
using System.Text;

namespace prep7
{
    public class Square : Shape
    {
        public double Side { get; set; }
        

        public Square(double side)
        {
            Side = side;
        }
        public override double Area()
        {
            return  Side* Side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}