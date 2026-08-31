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

        public static T FindMax<T>(T v1, T v2) where T : IComparable<T> 
        {
          if (v1.CompareTo(v2)>0) { return v1 ; }
          else { return v2;  }
        }
       
    }
}
