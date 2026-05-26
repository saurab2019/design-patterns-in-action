using DesignPatterns.AdapterPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    //Old System using Iterator
    public class ListClass : Iterator
    {
        List<int> list;
        int idx = -1;

        public ListClass()
        {
            list = new List<int>();
        }

        public void add(int obj)
        {
            list.Add(obj);
        }

        public bool hasNext()
        {
            return (list.Count() > idx + 1);
        }

        public int next()
        {
            if(hasNext())
            {
                int obj = list[idx+1];
                idx++;
                return obj;
            }
            throw new Exception("No element present");
        }

        public void remove()
        {
            if(hasNext())
            {
                list.RemoveAt(idx+1);
            }
        }

    }
}
