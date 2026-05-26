using DesignPatterns.FactoryMethodPattern.Factories;
using DesignPatterns.FactoryMethodPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.PizzaStore
{
    public class ChicgoPizzaStore : IPizzaStore
    {
        public readonly IngredientFactory factory = new ChicagoIngredientFactory();

        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new ChicagoStyleCheesePizza(factory);
            }
            else if (type.Equals("greek"))
            {
                pizza = new ChicagoStyleGreekPizza(factory);
            }
            return pizza;
        }
    }
}
