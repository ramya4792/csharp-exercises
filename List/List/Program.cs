using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int sum = sumOfEven(numbers);
            numbers.ForEach(Console.WriteLine);
            Console.WriteLine("Sum of even numbers in the list is: " + sum);
            Console.ReadLine();
        }
        public static int sumOfEven(List<int> number)
        {
            int sum = 0;
            for (int i=0;i<number.Count; i++)
            {                
                if (number[i] % 2 == 0)
                {
                    sum += number[i];
                }
            }
            return sum;
        }
    }
}
