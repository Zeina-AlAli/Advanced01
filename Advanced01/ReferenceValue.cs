using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class ReferenceValue<T> where T : class
    
    {
        public T Value { get; set; }
        public ReferenceValue(T value) { Value = value; }
    }
}
