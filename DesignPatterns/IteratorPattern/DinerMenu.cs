using DesignPatterns.IteratorPattern.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class DinerMenu : Iterable
    {
        private readonly int SIZE = 6;
        private MenuItem[] menuItems;
        private int numberOfItems = 0;

        public DinerMenu()
        {
            menuItems = new MenuItem[SIZE];
            addItem(new MenuItem("Diner Item1", "Diner Description 1", vegetarian: true, 5.6));
            addItem(new MenuItem("Diner Item2", "Diner Description 2", vegetarian: false, 7.0));
            addItem(new MenuItem("Diner Item3", "Diner Description 3", vegetarian: true, 4.2));
            addItem(new MenuItem("Diner Item4", "Diner Description 4", vegetarian: false, 8.1));
            addItem(new MenuItem("Diner Item5", "Diner Description 5", vegetarian: true, 5.7));

        }

        public void addItem(MenuItem item)
        {
            if(numberOfItems + 1 == SIZE)
            {
                Console.WriteLine("Sorry, menu is full can't add new Items");
            }
            menuItems[numberOfItems++] = item;
        }

        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }

        public MenuItem getItem(int index)
        {
            return menuItems[index];
        }

        public MenuItem[] getMenuItems()
        {
            return menuItems;
        }
    }
}
