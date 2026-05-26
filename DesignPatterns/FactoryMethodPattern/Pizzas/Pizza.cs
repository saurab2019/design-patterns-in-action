using DesignPatterns.FactoryMethodPattern.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Pizzas
{
    public abstract class Pizza
    {
        public Dough dough { get; set; }
        public Cheese cheese { get; set; }
        public abstract void prepare();
        public abstract void cut();
        public abstract void bake();
        public abstract void box();
    }
}
