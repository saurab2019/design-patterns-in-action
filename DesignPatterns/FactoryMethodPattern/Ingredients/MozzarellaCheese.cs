using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Ingredients
{
    public class MozzarellaCheese : Cheese
    {
        public override string Name => "Mozzarella Cheese";
        public MozzarellaCheese()
        {
            Console.WriteLine("Adding Mozzarella cheese");
        }
    }
}
