using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Factories
{
    public interface IngredientFactory
    {
        Dough createDough();
        Cheese createCheese();
    }
}
