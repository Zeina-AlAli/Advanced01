using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Advanced01
{
    internal class Pair<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }

        public Pair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }

        public override string ToString()
        {
            return $"{key} : {value}";
        }
    }
}
