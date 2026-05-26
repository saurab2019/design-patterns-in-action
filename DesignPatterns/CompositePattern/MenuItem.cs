using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public class MenuItem : MenuComponent
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public bool vegetarian { get; private set; }
        public double price { get; private set; }

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string getName()
        {
           return name;
        }
        public override string getDescription()
        {
            return description;
        }
        public override bool IsVegetarian()
        {
            return vegetarian;
        }
        public override double getPrice()
        {
            return price;
        }

        public override string ToString()
        {
            return $"\nMenu Item Details\nName: {this.name}\nDescription: {this.description}\nIs Vegeterian: {this.vegetarian}";
        }

        public override void print()
        {
            Console.WriteLine(this);
        }

    }
}
