using DesignPatterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.States
{
    public class SoldOutState : State
    {
        GunBallMachine gunBallMachine;

        public SoldOutState(GunBallMachine gunBallMachine)
        {
            this.gunBallMachine = gunBallMachine;
        }
        public void dispense()
        {
            Console.WriteLine("Currently there are no gunballs, has cannot proceed");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Currently there are no gunballs, has cannot proceed");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Currently there are no gunballs, has cannot proceed");
        }

        public void turnCrank()
        {
            Console.WriteLine("Currently there are no gunballs, has cannot proceed");
        }
    }
}
