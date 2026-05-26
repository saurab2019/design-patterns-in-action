using DesignPatterns.IteratorPattern.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public class PancakeHouseMenu : Iterable
    {
        List<MenuItem> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            addItem(new MenuItem("Pancake Item1", "Pancake Description 1", vegetarian: true, 2.9));
            addItem(new MenuItem("Pancake Item2", "Pancake Description 2", vegetarian: true, 1.9));
            addItem(new MenuItem("Pancake Item3", "Pancake Description 3", vegetarian: false, 4.3));
            addItem(new MenuItem("Pancake Item4", "Pancake Description 4", vegetarian: true, 4.1));
            addItem(new MenuItem("Pancake Item5", "Pancake Description 5", vegetarian: false, 3.0));
        }

        public void addItem(MenuItem item)
        {
            menuItems.Add(item);
        }

        public Iterator createIterator()
        {
            return new PancakeHouseIterator(menuItems);
        }

        public MenuItem getItem(int index)
        {
            return menuItems[index];
        }

        public List<MenuItem> getMenuItems()
        {
            return menuItems;
        }
    }
}
