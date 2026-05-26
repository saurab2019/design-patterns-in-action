using DesignPatterns.FactoryMethodPattern.Ingredients;
using DesignPatterns.FactoryMethodPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.PizzaStore
{
    public abstract class IPizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);

            if(pizza != null)
            {
                pizza.prepare();
                pizza.bake();
                pizza.cut();
                pizza.box();
            }
            else
            {
                Console.WriteLine($"{type}: type pizza not avaiable");
            }

            return pizza;

        }

        public abstract Pizza createPizza(string type);
    }
}
