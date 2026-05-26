using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public class Waitress
    {
        MenuComponent menuComponent;

        public Waitress(MenuComponent menuComponent)
        {
            this.menuComponent = menuComponent;
        }

        public void print()
        {
            menuComponent.print();
        }
    }
}
