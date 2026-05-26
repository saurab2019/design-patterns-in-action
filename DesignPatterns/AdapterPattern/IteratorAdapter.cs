using DesignPatterns.AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    //IteratorAdpater with Target Interface = Iterator which is used by old system
    public class IteratorAdapter : Enumeration<int>
    {
        Iterator iterator;

        public IteratorAdapter(Iterator iterator)
        {
            this.iterator = iterator;
        }

        public bool hasMoreElements()
        {
            return iterator.hasNext();
        }

        public int nextElement()
        {
            return iterator.next();
        }

 
    }
}
