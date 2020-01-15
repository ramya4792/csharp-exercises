using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,1,2,3,5,8};
            Console.WriteLine("Array items are:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
            Console.ReadLine();
        }
    }
}
