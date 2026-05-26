using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public class Menu : MenuComponent
    {
        List<MenuComponent> menus = new List<MenuComponent>();
        public string name { get; private set; }
        public string description { get; private set; }

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void add(MenuComponent component)
        {
            menus.Add(component);
        }

        public override void remove(MenuComponent component)
        {
            menus.Remove(component);
        }

        public override string getName()
        {
            return name;
        }

        public override string getDescription()
        {
            return description;
        }
        public override void print()
        {
            Console.WriteLine($"\nMENU...\nMenu name: {name}\nMenu description: {description}\n");
            foreach (MenuComponent component in menus)
            {
                component.print();
            }
           
        }
    }
}
