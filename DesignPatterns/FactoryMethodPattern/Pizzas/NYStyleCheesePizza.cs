using DesignPatterns.FactoryMethodPattern.Factories;
using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        IngredientFactory factory;

        public NYStyleCheesePizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        public override void bake()
        {
            Console.WriteLine("Baking NYStyleCheesePizza .....");
        }

        public override void box()
        {
            Console.WriteLine("Boxing NYStyleCheesePizza .....");

        }

        public override void cut()
        {
            Console.WriteLine("Cutting NYStyleCheesePizza .....");
        }

        public override void prepare()
        {
            Console.WriteLine("Making preparations for NYStyleCheesePizza .....");
            this.dough = factory.createDough();
            this.cheese = factory.createCheese();
        }
    }
}
