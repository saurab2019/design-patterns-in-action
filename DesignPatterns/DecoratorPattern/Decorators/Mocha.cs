using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class Mocha : Beverage
    {
        Beverage beverage;
        public Mocha(Beverage beverage) : base(beverage.getDescription() + " + Mocha")
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            double beverageCost = beverage.cost();
            Console.WriteLine($"Cost of {beverage.getDescription()}: {beverageCost}");
            return 0.20 + beverageCost;
        }
    }
}
