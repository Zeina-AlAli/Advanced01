using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class CacheItem<Tvalue>

    {
        public Tvalue Value { get; set; }
        public DateTime Experation {  get; set; }

    }
}
