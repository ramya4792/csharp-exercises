using System;

namespace AreaOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, area;
            Console.WriteLine("Enter the length of the rectangle");
            length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            width = int.Parse(Console.ReadLine());
            area = length * width;
            Console.WriteLine("Area of the rectangel is: " +area);
            Console.ReadLine();          
        }
    }
}
