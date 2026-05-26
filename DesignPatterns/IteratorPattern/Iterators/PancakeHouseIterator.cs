using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern.Iterators
{
    public class PancakeHouseIterator : Iterator
    {
        List<MenuItem> items;
        int idx = 0;
        public PancakeHouseIterator(List<MenuItem> menuItems) 
        {
            this.items = menuItems;
        }
        public bool hasNext()
        {
            return idx < items.Count;
        }

        public MenuItem next()
        {
            return items[idx++];
        }
    }
}
