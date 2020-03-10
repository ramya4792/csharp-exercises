using System;

namespace prep7
{
    class Program
    {
        static void Main(string[] args)
        {
         
            
            Square s = new Square(2);
            Rectangle r = new Rectangle(4, 5);
            Circle c = new Circle(2);
            Console.WriteLine("Area of Shapes are"+"\nSquare:"+s.Area()+"\nRectangle:"+r.Area()+ "\nCircle:" +c.Area());
            Console.WriteLine("\nPerimeter of shapes are"+"\nSquare:"+s.Perimeter()+"\nRectangle:"+r.Perimeter()+"\nCircle:"+c.Perimeter());
            Console.ReadLine();

        }
    }
}
