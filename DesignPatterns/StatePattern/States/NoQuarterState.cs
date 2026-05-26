using DesignPatterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.States
{
    public class NoQuarterState : State
    {
        GunBallMachine gunBallMachine;

        public NoQuarterState(GunBallMachine gunBallMachine)
        {
            this.gunBallMachine = gunBallMachine;
        }
        public void dispense()
        {
            Console.WriteLine("You first need to insert a quarter");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("You first need to insert a quarter");
        }

        public void insertQuarter()
        {
            Console.WriteLine("Inserting quarter.....");
            gunBallMachine.setState(gunBallMachine.getHasQuarterState());
        }

        public void turnCrank()
        {
            Console.WriteLine("You first need to insert a quarter");
        }
    }
}
