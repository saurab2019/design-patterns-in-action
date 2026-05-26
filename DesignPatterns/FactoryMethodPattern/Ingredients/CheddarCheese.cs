using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Ingredients
{
    public class CheddarCheese : Cheese
    {
        public override string Name => "Cheddar Cheese";
        public CheddarCheese()
        {
            Console.WriteLine("Adding Cheddar cheese");
        }
    }
}
