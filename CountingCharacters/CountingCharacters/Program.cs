using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;


namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            
            string str;
            //extract from textfie
            str = File.ReadAllText(@"E:\CoderGirl\C#\studios\CountingCharacters\txtFile.txt");
            Console.WriteLine("String is: \n"+str);
            //input string through control panel
            /*Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            */
            //case insensitive
            str = str.ToLower();
            //exclude non-aplhabets
            Regex rgx = new Regex("[^a-zA-Z]");
            str = rgx.Replace(str, "");
            str = str.Trim();
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (!count.ContainsKey(str[i]))
                    count.Add(str[i], 1);
                else
                    count[str[i]]++;                   

            }
            //displaying
            Console.WriteLine("Count of characters:");
            foreach(KeyValuePair<char,int>counts in count)
            {
                Console.WriteLine(counts.Key + ":" + counts.Value);
            }
            Console.ReadLine();
        }
    }
}
