using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNewItem { get; set; }

        public MenuItem(string name, double price, string description, string category, bool isNewItem)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            this.IsNewItem = isNewItem;
        }

        public MenuItem(string name, double price, string description, string category)
            : this(name, price, description, category, true) { }



    }
}
