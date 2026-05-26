using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern.Interfaces
{
    public interface Enumeration<T>
    {
        bool hasMoreElements();
        T nextElement();
    }
}
