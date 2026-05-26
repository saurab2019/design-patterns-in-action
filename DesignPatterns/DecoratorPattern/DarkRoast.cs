using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast(string description) : base(description)
        {
            Console.WriteLine("DarkRoast class contructor called");
        }

        public override double cost()
        {
            return 5;
        }
    }
}
