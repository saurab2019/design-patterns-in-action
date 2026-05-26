using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern.Decorators
{
    public class Soy : Beverage
    {
        Beverage beverage;
        public Soy(Beverage beverage) : base(beverage.getDescription() + " + soy")
        {
            this.beverage = beverage;
        }
        public override double cost()
        {
            double beverageCost = beverage.cost();
            Console.WriteLine($"Cost of {beverage.getDescription()}: {beverageCost}");
            return 0.30 + beverageCost;
        }
    }
}
