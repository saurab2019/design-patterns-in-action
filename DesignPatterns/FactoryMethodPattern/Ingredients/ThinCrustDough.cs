using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Ingredients
{
    public class ThinCrustDough : Dough
    {
        public override string Name => "Thin Crust Dough";

        public override string shape => "Square";

        public ThinCrustDough() 
        {
            Console.WriteLine("Making Thin crust dough");
        }
    }
}
