using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Factories
{
    public class ChicagoIngredientFactory : IngredientFactory
    {
        public Cheese createCheese()
        {
            return new CheddarCheese();
        }

        public Dough createDough()
        {
            return new ThickCrustDough();
        }
    }
}
