using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class CafeBeverage
    {
        public void prepare()
        {
            boilWater();
            brew();
            pourInCup();
            if(customerWantsCondiments())
            {
                addCondiments();
            }
        }

        public abstract void brew();
        public abstract void addCondiments();

        public void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public virtual bool customerWantsCondiments()
        {
            return true;
        }
    }

}
