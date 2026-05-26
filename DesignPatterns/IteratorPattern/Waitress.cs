using DesignPatterns.AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public enum Menu
    {
        BREAKFAST,
        LUNCH
    }

    public class Waitress
    {
        Dictionary<Menu, Iterable> menuDictionary;

        public Waitress(Dictionary<Menu, Iterable> menus)
        {
            this.menuDictionary = menus;
        }

        public void printMenus()
        {
            foreach (var menuMapping in  menuDictionary)
            {
                printMenu(menuMapping.Value);
            }
            
        }

        public void printMenu(Iterable menu)
        {
            Iterator iterator = menu.createIterator();
            while (iterator.hasNext())
            {
                Console.WriteLine(iterator.next());
            }
        }

        public void printBreakFastMenu()
        {
            printMenu(menuDictionary[Menu.BREAKFAST]);
        }

        public void printLunchMenu()
        {
            printMenu(menuDictionary[Menu.LUNCH]);
        }
    }
}
