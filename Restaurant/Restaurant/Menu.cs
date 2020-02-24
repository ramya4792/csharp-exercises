using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    class Menu 
    {
        
        public MenuGroup Name { get; set; }
        public enum MenuGroup { Breakfast, LunchOrDinner, Kids };
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();

        public bool IsUpdated {
            get
            {
                return Items.Any(x => x.IsNew);
            }
        }
       
        public void AddItem(string name, MenuItem.Category category, string description, double cost)
        {
            MenuItem newItem = new MenuItem();
            newItem.Name = name;
            newItem.Description = description;
            newItem.Cost = cost;
            newItem.ItemCategory = category;
            newItem.NewItem = DateTime.Now.Date;
            Items.Add(newItem);
            
        }
        public void RemoveItem(string name)
        {
            MenuItem newItem = new MenuItem();
            newItem.Name = name;
            Items.Remove(newItem);
        }
        public void Display()
        {
           
            foreach(var item in Items)
            {
                Console.WriteLine(item);
            }
            
        }
      

    }
}
