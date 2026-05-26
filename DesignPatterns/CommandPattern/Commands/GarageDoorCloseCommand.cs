using DesignPatterns.CommandPattern.Invoker;
using DesignPatterns.CommandPattern.Recievers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands
{
    public class GarageDoorCloseCommand : Command
    {
        GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void execute()
        {
            garageDoor.lightOff();
            garageDoor.down();
            garageDoor.stop();
        }

        public void undo()
        {
            garageDoor.up();
            garageDoor.stop();
            garageDoor.lightOn();
        }
    }
}
