using DesignPatterns.FactoryMethodPattern.Factories;
using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Pizzas
{
    public class ChicagoStyleGreekPizza : Pizza
    {
        IngredientFactory factory;

        public ChicagoStyleGreekPizza(IngredientFactory factory)
        {
            this.factory = factory;
        }

        public override void bake()
        {
            Console.WriteLine("Baking ChicagoStyleGreekPizza .....");
        }

        public override void box()
        {
            Console.WriteLine("Boxing ChicagoStyleGreekPizza .....");

        }

        public override void cut()
        {
            Console.WriteLine("Cutting ChicagoStyleGreekPizza .....");
        }

        public override void prepare()
        {
            Console.WriteLine("Making preparations for ChicagoStyleGreekPizza .....");
            this.dough = factory.createDough();
            this.cheese = factory.createCheese();
        }
    }
}
