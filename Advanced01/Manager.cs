using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Manager<T> where T : class , IPrintable, new() 
    {
        public T GetAndPrint()
        {
            T item = new T();
            item.Print();
            return item;
        }
    }
}
