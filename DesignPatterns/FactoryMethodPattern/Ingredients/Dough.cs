using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern.Ingredients
{
    public abstract class Dough
    {
        public abstract string Name { get; }

        public abstract string shape { get; }
    }
}
