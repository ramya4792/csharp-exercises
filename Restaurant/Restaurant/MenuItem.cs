using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    class MenuItem
    {
        public static int itemId = 1;
        public int Id{ get; private set; }
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



    }
}
