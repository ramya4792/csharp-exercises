
using System;

namespace stringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
            Console.WriteLine("Enter a word to search in Alice in wonderland");
            string name = Console.ReadLine();

            if (str.ToLower().IndexOf(name.ToLower())!=-1)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();
        }
    }
}
