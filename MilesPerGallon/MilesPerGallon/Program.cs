using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            int miles, gas, MilesPerGallon;
            Console.WriteLine("Enter the miles you have driven: ");
            miles = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount of gas comsumed: ");
            gas = int.Parse(Console.ReadLine());
            MilesPerGallon = miles / gas;
            Console.WriteLine("" + MilesPerGallon + " miles per gallon");
            Console.ReadLine();
        }
    }
}
