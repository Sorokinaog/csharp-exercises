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

        public override string ToString()
        {
            string menuStr = String.Format("Updated ({0}):{1}", this.Updated, Environment.NewLine);
            foreach (MenuItem menuItem in this.MenuItems)
            {
                menuStr = menuStr + menuItem.ToString() + Environment.NewLine;
            }

            return menuStr;
        }
    }





}
