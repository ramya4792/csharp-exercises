using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
  
        public string Name { get; internal set; }
        public double Cost { get; internal set; }
        public Category ItemCategory { get;  set; }
        public enum Category { Appetizer, MainCourse, Dessert}
        public string Description { get; internal set; }
        public DateTime NewItem { get; internal set; }
        public bool IsNew
        {
            get
            {
                return NewItem.Date >= DateTime.Now.Date.AddMonths(-3);
            }
        }
        
        public override string ToString()
        {
            return "Item:" + Name + "--Description:" + Description + "--Category:" +ItemCategory+ "--Price:" + Cost;
        }
        public override bool Equals(object obj)
        {
            MenuItem menuObj = obj as MenuItem;
            return Name == menuObj.Name;
        }
        

    }
}
