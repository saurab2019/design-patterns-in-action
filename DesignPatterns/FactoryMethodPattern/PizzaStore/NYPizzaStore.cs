using DesignPatterns.FactoryMethodPattern.Factories;
using DesignPatterns.FactoryMethodPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.PizzaStore
{
    //Simple Factory Pattern
    public class NYPizzaStore : IPizzaStore
    {
        public readonly IngredientFactory factory = new NYIngredientFactory();

        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new NYStyleCheesePizza(factory);
            }
            else if (type.Equals("greek"))
            {
                pizza = new NYStyleGreekPizza(factory);
            }
            return pizza;
        }
    }
}
