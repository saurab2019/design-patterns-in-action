using DesignPatterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.States
{
    public class HasQuarterState : State
    {
        GunBallMachine gunBallMachine;

        public HasQuarterState(GunBallMachine gunBallMachine)
        {
            this.gunBallMachine = gunBallMachine;
        }
        public void dispense()
        {
            Console.WriteLine("Wrong operation, you first need to turn the crank");
        }

        public void ejectQuarter()
        {
            Console.WriteLine("Ejecting Quarter...");
            gunBallMachine.setState(gunBallMachine.getNoQuarterState());

        }

        public void insertQuarter()
        {
            Console.WriteLine("You can not insert 2 quarters");
        }

        public void turnCrank()
        {
            Console.WriteLine("Turning crank...");
            gunBallMachine.setState(gunBallMachine.getSoldState());
        }
    }
}
