using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands
{
    public class AllOnCommand : Command
    {
        Dictionary<Command, int> commandDictionary;

        public AllOnCommand(Dictionary<Command, int> commandDictionary)
        {
            this.commandDictionary = commandDictionary;
        }

        public void addCommand(Command command)
        {
            commandDictionary[command]++;
        }

        public void removeCommand(Command command)
        {
            if (commandDictionary.ContainsKey(command))
            {
                if (commandDictionary[command] > 0)
                {
                    commandDictionary[command]--;
                }
                else
                {
                    commandDictionary.Remove(command);
                }
            }
        }

        public void execute()
        {
            foreach (var command in commandDictionary.Keys)
            {
                command.execute();
            }
        }

        public void undo()
        {
            foreach(var command in commandDictionary.Keys)
            {
                command.undo();
            }
        }
    }
}
