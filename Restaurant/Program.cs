using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.AddMenuItem(new MenuItem("Roast Pork Loin", 19.95, "Slow roasted pork loin finished with a portabella demi-glace.", "main course"));
            menu.AddMenuItem(new MenuItem("Spinach Salad", 7.95, "Fresh spinach, mushrooms, and hard-boiled egg served with warm bacon vinaigrette.", "appetizer", false));
            menu.AddMenuItem(new MenuItem("Profiterole", 7.99, "Salted Caramel Ice Cream, Chocolate Sauce, Caramelized Pecan", "dessert"));
            Console.WriteLine(menu.ToString());
            Console.ReadLine();
        }
    }

}
