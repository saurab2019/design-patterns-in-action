using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Recievers
{
    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light is ON");
        }

        public void off() { Console.WriteLine("Light is Off"); }
    }
}
