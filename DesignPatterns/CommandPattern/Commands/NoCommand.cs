using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern.Commands
{
    public class NoCommand : Command
    {
        public void execute()
        {
        }

        public void undo()
        {
        }
    }
}
