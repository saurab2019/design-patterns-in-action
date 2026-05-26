using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Recievers
{
    public class GarageDoor
    {
        public void up()
        {
            Console.WriteLine("Garage Door is UP");
        }

        public void down()
        { Console.WriteLine("Garage Door is DOWN"); }

        public void stop()
        {
            Console.WriteLine("Garage Door is stopped");
        }
        public void lightOn()
        {
            Console.WriteLine("Light of Garage is On");
        }

        public void lightOff()
        {
            Console.WriteLine("Light of Garage is Off");
        }
          
       
    }
}
