using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Factories
{
    public class NYIngredientFactory : IngredientFactory
    {
        public Cheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }
    }
}
