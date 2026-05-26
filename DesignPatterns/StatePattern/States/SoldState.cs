using DesignPatterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.States
{
    public class SoldState : State
    {
        GunBallMachine gunBallMachine;

        public SoldState(GunBallMachine gunBallMachine)
        {
            this.gunBallMachine = gunBallMachine;
        }
        public void dispense()
        {
            Console.WriteLine("Dispensing gunballs.....");
            if(gunBallMachine.count > 0)
            {
                gunBallMachine.count--;
                Console.WriteLine("Enjoy your gunballs...");
                gunBallMachine.setState(gunBallMachine.getNoQuarterState());
            }
            else
            {
                Console.WriteLine("Gunballs sold out...");
                gunBallMachine.setState(gunBallMachine.getSoldOutState());
            }
        }

        public void ejectQuarter()
        {
            Console.WriteLine("you already turn up the crank, hence cannot get a quarter back");
        }

        public void insertQuarter()
        {
            Console.WriteLine("You can not insert 2 quarters");
        }

        public void turnCrank()
        {
            Console.WriteLine("Crank is already turned, hence can not do it again");
        }
    }
}
