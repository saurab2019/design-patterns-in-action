using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CompositePattern
{
    public abstract class MenuComponent
    {
        public virtual string getName()
        {
            throw new NotSupportedException("Action Not Supported");
        }
        public virtual string getDescription()
        {
            throw new NotSupportedException("Action Not Supported");
        }
        public virtual bool IsVegetarian()
        {
            throw new NotSupportedException("Action Not Supported");
        }
        public virtual double getPrice()
        {
            throw new NotSupportedException("Action Not Supported");
        }
        public virtual void print()
        {
            throw new NotSupportedException("Action Not Supported"); 
        }
        public virtual MenuComponent getChild()
        {
            throw new NotSupportedException("Action Not Supported");
        }
        public virtual void add(MenuComponent child)
        {
            throw new NotSupportedException("Action Not Supported");
        }
        public virtual void remove(MenuComponent child)
        {
            throw new NotSupportedException("Action Not Supported");
        }
    }
}
