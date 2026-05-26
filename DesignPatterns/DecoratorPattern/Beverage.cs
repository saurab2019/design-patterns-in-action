using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class Beverage
    {
        private string description;

        public Beverage(string description)
        {
            this.description = description;
            Console.WriteLine("Beverage class constructor called");
        }

        public string getDescription()
        {
            return description;
        }

        public abstract double  cost();
    }
}
