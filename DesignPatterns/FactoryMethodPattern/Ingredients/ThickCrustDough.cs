using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Ingredients
{
    public class ThickCrustDough : Dough
    {

        public ThickCrustDough()
        {
            Console.WriteLine("Making Thick crust dough");
        }

        public override string Name => "Thick Crust Dough";

        public override string shape => "Circle";
    }
}
