using System;


namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            MenuItem item = new MenuItem();
            
            menu.AddItem("French Fries", MenuItem.Category.Appetizer, "deep fried potato stripes", 2.99);
            menu.AddItem("Chicken nuggets", MenuItem.Category.Appetizer, "deep fried meat", 4.99);
            menu.Display();
            Console.WriteLine("After remove");
            menu.RemoveItem("French Fries");
            menu.Display();

            Console.ReadLine();
        }
    }
}
