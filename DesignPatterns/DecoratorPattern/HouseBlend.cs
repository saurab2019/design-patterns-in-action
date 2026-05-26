using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(string description) : base(description)
        {
            Console.WriteLine("Houseblend class contructor called");
        }

        public override double cost()
        {
            return 5;
        }
    }
}
