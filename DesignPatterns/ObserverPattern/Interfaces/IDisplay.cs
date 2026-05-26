using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern.interfaces
{
    public interface IDisplay : IObserver
    {
        void display();
    }
}
