using DesignPatterns.FactoryMethodPattern.Factories;
using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Pizzas
{
    public class NYStyleGreekPizza : Pizza
    {
        IngredientFactory factory;

        public NYStyleGreekPizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        public override void bake()
        {
            Console.WriteLine("Baking NYStyleGreekPizza .....");
        }

        public override void box()
        {
            Console.WriteLine("Boxing NYStyleGreekPizza .....");

        }

        public override void cut()
        {
            Console.WriteLine("Cutting NYStyleGreekPizza .....");
        }

        public override void prepare()
        {
            Console.WriteLine("Making preparations for NYStyleGreekPizza .....");
            this.dough = factory.createDough();
            this.cheese = factory.createCheese();

        }
    }
}
