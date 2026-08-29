using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class StructValue<T> where T : struct
    {
        public T Value { get; set; }
        public StructValue(T value) { Value = value; }

    }
}
