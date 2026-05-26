using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands
{
    public class MacroCommand : Command
    {
        Command[] commands;

        public MacroCommand(Command[] commands)
        {
            this.commands = commands;
        }

        public void execute()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].execute();
            }
        }

        public void undo()
        {
            for (int i = 0; i < commands.Length; i++)
            {
                commands[i].undo();
            }
        }
    }
}
