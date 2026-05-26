using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StatePattern.States
{
    public interface State
    {
        void insertQuarter();
        void ejectQuarter();
        void dispense();
        void turnCrank();

    }
}
