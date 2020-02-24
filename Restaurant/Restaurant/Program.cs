using System;


namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            string option, password;
            Menu menu = new Menu();
            
            //Add an item to the menu
            menu.AddItem("French Fries", MenuItem.Category.Appetizer, "deep fried potato stripes", 2.99);
            menu.AddItem("Chicken nuggets", MenuItem.Category.Appetizer, "deep fried meat", 4.99);
            
            //continue loop until user press ENTER
            do
            {
                
                Console.WriteLine("\nChoose option \n 1.View Menu \n 2.Add/Remove an item");
                option = Console.ReadLine();
                //display option
                if(option == "1")
                {
                    menu.Display();
                }//add and remove option
                else if(option == "2")
                {
                    //password protected
                    Console.WriteLine("Only Admin can add or remove an item. \nEnter password to Add or remove");
                    password = Console.ReadLine();
                    //password to Enter is "Password"
                    //password matches choose add/remove
                    if(password == "Password")
                    {
                        Console.WriteLine("1.Add\n2.Remove");
                        int adminOption = int.Parse(Console.ReadLine());
                        switch(adminOption)
                        {
                            //add enter the name description cost and category
                            case 1:
                                Console.WriteLine("\nEnter name of the item");
                                string addName = Console.ReadLine();
                                Console.WriteLine("\nAdd a description to the item");
                                string addDesc = Console.ReadLine();
                                Console.WriteLine("\nChoose item category \n 1.Appetizer \n 2.Main Course \n 3.Dessert");
                                string addCategory = Console.ReadLine();
                                Console.WriteLine("\nDecide price of the Item");
                                double addCost = double.Parse(Console.ReadLine());
                                //Adding according to the category
                                switch (addCategory)
                                {
                                    case "1":
                                        menu.AddItem(addName, MenuItem.Category.Appetizer, addDesc, addCost);
                                        break;
                                    case "2":
                                        menu.AddItem(addName, MenuItem.Category.MainCourse, addDesc, addCost);
                                        break;
                                    case "3":
                                        menu.AddItem(addName, MenuItem.Category.Dessert, addDesc, addCost);
                                        break;
                                }                                
                                break;
                            //get name to remove item
                            case 2:
                                Console.WriteLine("\nEnter name of the item to remove");
                                string removeName = Console.ReadLine();
                                menu.RemoveItem(removeName);
                                break;
                        }
                    }
                }

            } while (option != "");
            
        }
    }
}
