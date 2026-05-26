using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DesignPatterns.IteratorPattern.Iterators
{
    public class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int idx = 0;
        public DinerMenuIterator(MenuItem[] menuItems)
        {
            this.items = menuItems;
        }
        public bool hasNext()
        {
            return idx < items.Length;
        }

        public MenuItem next()
        {
            return items[idx++];
        }
    }
}
