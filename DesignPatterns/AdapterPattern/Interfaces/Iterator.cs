using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Interfaces
{
    //Target Interface
    public interface Iterator
    {
        bool hasNext();
        int next();
        void remove(); 
    }
}
