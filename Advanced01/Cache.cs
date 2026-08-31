using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Cache<TKey, TValue>
    {
       
        private Dictionary<TKey, CacheItem<TValue>> items = new Dictionary<TKey, CacheItem<TValue>>();

       public void Add(TKey key, TValue value, int sec)
        {

            items[key] = new CacheItem<TValue>
            {
                Value = value,
                Experation = DateTime.Now.AddSeconds(sec)
            };

            Console.WriteLine("Item is added.");
            
        }
        public void Remove(TKey key)
        {
            items.Remove(key);
            Console.WriteLine("Item is removed");
        }
        public TValue Get(TKey key)
        {
            if (items.ContainsKey(key))
            {
                if (DateTime.Now < items[key].Experation && items[key].Value != null)
                {
                    Console.Write($"Item {key} : ");
                    return items[key].Value;
                }
                Console.WriteLine("Item is expired");
                items.Remove(key );
            } 

            return default(TValue);
            
        }
        public bool Contain(TKey key)
        {
            if(items.ContainsKey(key))
            {
                if( DateTime.Now < items[key].Experation)
                return true;

                items.Remove(key);
            }
            return false;
        }


    }
}
