using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Container<T>
    {
        private T item;
        public void Add(T item)
        { 
            this.item = item;
        }

        public T Get() 
        {
            return item;
        }
    }
}
