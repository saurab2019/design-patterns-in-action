using DesignPatterns.StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.Context
{
    public class GunBallMachine
    {
        private State hasQuarterState;
        private State NoQuarterState;
        private State soldOutState;
        private State soldState;

        private State currentState;
        public int count { get; set; }

        public GunBallMachine(int count)
        {
            this.hasQuarterState = new HasQuarterState(this);
            this.NoQuarterState = new NoQuarterState(this);
            this.soldOutState = new SoldOutState(this);
            this.soldState = new SoldState(this);
            if (count > 0)
            {
                currentState = NoQuarterState;
                this.count = count; 
            }
            else
            {
                currentState = soldOutState;
                count = 0;
            }
        }
 
        public void setState(State state)
        {
            currentState = state;
        }

        public State getHasQuarterState()
        {
            return hasQuarterState;
        }

        public State getNoQuarterState()
        {
            return NoQuarterState;
        }

        public State getSoldState()
        {
            return soldState;
        }

        public State getSoldOutState()
        {
            return soldOutState;
        }

        public void insertQuarter()
        {
            currentState.insertQuarter();
        }

        public void ejectQuarter()
        {
            currentState.ejectQuarter();
        }

        public void turnCrank()
        {
            currentState.turnCrank();
            if(currentState == soldState)
            {
                currentState.dispense();
            }
        }
    }
}
