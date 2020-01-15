using System;

namespace Dictonary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            int[] id = new int[10];
            string newStudent;
            int num=0;
            Console.WriteLine("Enter names and press ENTER to finish");
            do
            {
                newStudent = Console.ReadLine();
                if(newStudent!= "")
                {
                    names[num] = newStudent;
                    num++;
                }
            } while (newStudent != ""&&num<10);
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Id of  " + names[i] + " is:");
                int nameId = int.Parse(Console.ReadLine());
                id[i] = nameId;
            }
            Console.WriteLine("\n Class roster:");
            for(int i=0; i < num; i++)
            {
                Console.WriteLine(names[i] + "-" + id[i]);
            }
            Console.ReadLine();
        }
    }
}
