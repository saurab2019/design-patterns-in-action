using DesignPatterns.FactoryMethodPattern.Factories;
using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        IngredientFactory factory;

        public ChicagoStyleCheesePizza(IngredientFactory factory)
        {
            this.factory = factory;
        }
        public override void bake()
        {
            Console.WriteLine("Baking ChicagoStyleCheesePizza .....");
        }

        public override void box()
        {
            Console.WriteLine("Boxing ChicagoStyleCheesePizza .....");

        }

        public override void cut()
        {
            Console.WriteLine("Cutting ChicagoStyleCheesePizza .....");
        }

        public override void prepare()
        {
            Console.WriteLine("Making preparations for ChicagoStyleCheesePizza .....");
            this.dough = factory.createDough();
            this.cheese = factory.createCheese();
        }
    }
}
