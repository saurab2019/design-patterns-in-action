using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class Whip : Beverage
    {
        Beverage beverage;
        public Whip(Beverage beverage) : base(beverage.getDescription() + " + whip")
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            double beverageCost = beverage.cost();
            Console.WriteLine($"Cost of {beverage.getDescription()}: {beverageCost}");
            return 0.50 + beverageCost;
        }
    }
}
