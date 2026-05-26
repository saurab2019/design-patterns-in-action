using DesignPatterns.CommandPattern.Invoker;
using DesignPatterns.CommandPattern.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands
{
    public class GarageDoorOpenCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.up();
            garageDoor.stop();
            garageDoor.lightOn();
        }

        public void undo()
        {
            garageDoor.lightOff();
            garageDoor.down();
            garageDoor.stop();
        }
    }
}
