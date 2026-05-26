using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class Milk : Beverage
    {
        Beverage beverage;
        public Milk(Beverage beverage) : base(beverage.getDescription() + " + Milk")
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            double beverageCost = beverage.cost();
            Console.WriteLine($"Cost of {beverage.getDescription()}: {beverageCost}");
            return 0.10 + beverageCost;
        }
    }
}
