using System;

namespace areaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, area;
            do
            {
                Console.WriteLine("Enter the radius of circle and 0 to quit: ");
                radius = double.Parse(Console.ReadLine());
                if (radius > 0)
                {
                    area = Math.PI * radius * radius;
                    Console.WriteLine("The area of circle with radius " + radius + " is: " + area);
                }
                else if(radius <0)
                {
                    Console.WriteLine("You entered a negative number");
                }
            } while (radius != 0);
            Console.ReadLine();
        }
    }
}
