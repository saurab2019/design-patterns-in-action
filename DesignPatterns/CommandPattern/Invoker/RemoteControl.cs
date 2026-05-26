using DesignPatterns.CommandPattern.Commands;
using System.Collections.Generic;

namespace DesignPatterns.CommandPattern.Invoker
{
    public class RemoteControl
    {
        Command[] OnCommands = new Command[7];
        Command[] OffCommands = new Command[7];
        Stack<Command> prevCommandStack;

        public RemoteControl()
        {
            for(int slot  = 0; slot < 7; slot++)
            {
                Command command =  new NoCommand();
                OnCommands[slot] = command;
                OffCommands[slot] = command;
            }
            prevCommandStack = new Stack<Command>();
        }

        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            if(slot >= 0 && slot < 7)
            {
                OnCommands[slot] = onCommand;
                OffCommands[slot] = offCommand;
            }
        }

        public void buttonOnPressed(int slot)
        {
            if(slot >= 0 && slot < 7)
            {
                prevCommandStack.Push(OnCommands[slot]);
                OnCommands[slot].execute();
            }
        }

        public void buttonOffPressed(int slot)
        {
            if (slot >= 0 && slot < 7)
            { 
                prevCommandStack.Push(OffCommands[slot]);
                OffCommands[slot].execute();
            }
        }

        public void buttonUndoPressed()
        {
            if (prevCommandStack.Count > 0)
            {
                prevCommandStack.Pop().undo();

            }
        }
    }
}
