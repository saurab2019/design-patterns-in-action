using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    public interface Iterator
    {
        //private int idx = 0;
        //public abstract Iterator createIterator();

        bool hasNext();

        MenuItem next();
    }
}
