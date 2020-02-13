using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class Menu
    {       
        public MenuGroup Name { get; set; }
        public List<MenuItem> Items { get; set; } = new List<MenuItem>();

        public bool IsUpdated { get; set; }

        public enum MenuGroup {Breakfast, LunchOrDinner, Kids };

    }
}
