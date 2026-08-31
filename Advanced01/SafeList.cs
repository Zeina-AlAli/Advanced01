using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class SafeList<T>
    {
        List<T> item = new List<T>();
        public void AddItem(T item)
        {
            this.item.Add(item);
            Console.WriteLine($"{item} is added.");
        }
        public T GetItem(int index)
        {
            if (index != 0 && item[index] != null)
            { Console.Write("Item is found : "); return item[index]; }
            Console.WriteLine("Item doesnt exist.\n");
            return default;
        }
    }
}
