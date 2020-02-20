using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Restaurant
{
    class Menu 
    {
        MenuItem newItem = new MenuItem();
        public MenuGroup Name { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();

        public bool IsUpdated {
            get
            {
                return Items.Any(x => x.IsNew);
            }
        }

        public enum MenuGroup {Breakfast, LunchOrDinner, Kids };
        
        public void AddItem(string name, MenuItem.Category category, string description, double cost)
        {
            
            newItem.Name = name;
            newItem.Description = description;
            newItem.Cost = cost;
            newItem.ItemCategory = category;
            Items.Add(newItem);
        }
        public void RemoveItem(string name)
        {
            
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
