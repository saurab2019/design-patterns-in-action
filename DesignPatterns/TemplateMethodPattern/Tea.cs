using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class Tea : CafeBeverage
    {
      
        public override void addCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        public override void brew()
        {
            Console.WriteLine("Dipping tea bag for 2 mins");
        }

        public string askCustomer()
        {
            Console.WriteLine("Hi, Do you want to add lemon in the tea (y/n)");
            string reply = Console.ReadLine();
            return reply;
        }
        public override bool customerWantsCondiments()
        {
            string reply = askCustomer();
            if(reply == null)
            {
                return false; 
            }
            return reply.ToLower().StartsWith("y");
        }
    }
}
