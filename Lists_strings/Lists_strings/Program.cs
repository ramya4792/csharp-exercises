using System;
using System.Collections.Generic;

namespace Lists_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "ramya", "austin", "krish", "james", "naga", "indra" };
            Console.WriteLine("Names in the list are: ");
            names.ForEach(Console.WriteLine);
            List<string> newNames = wordWith5(names); 
            Console.WriteLine("Names that contain 5 letters in the list are: ");
            newNames.ForEach(Console.WriteLine);
            Console.ReadLine();
        }
        static List<string> wordWith5(List<string> name)
        {
            List<string> newList = new List<string>();
            for(int i=0;i<name.Count; i++)
            {
                if (name[i].Length == 5)
                {
                    newList.Add(name[i]);
                }
            }
            return newList;
        }
    }
}
