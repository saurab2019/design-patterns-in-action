using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class Coffee : CafeBeverage
    {
        public override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void brew()
        {
            Console.WriteLine("Brewing coffee in hot water");
        }
    }
}
