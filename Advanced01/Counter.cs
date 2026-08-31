using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Counter<T>
    {
        public static int count = 0;
        public Counter() 
        {
            count++;  
        }
    }
}
