using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class GenericMethod
    {
        

        public static void Swap<T>(ref T T1, ref T T2 )
        {
            T temp = T1;
            T1 = T2;
            T2 = temp;
        }
    }
}
