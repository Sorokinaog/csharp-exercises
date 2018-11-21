using System;
using System.Collections.Generic;
using System.Text;


namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; }
        public DateTime Updated { get; private set; }

        public Menu()
        {
            this.MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Add(menuItem);
            this.Updated = DateTime.Now;
        }

        public void DeleteMenuItem(MenuItem menuItem)
        {
            this.MenuItems.Remove(menuItem);
            this.Updated = DateTime.Now;
        }
    }



}
