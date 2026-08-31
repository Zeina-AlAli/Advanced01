using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class InterfaceConstraint<T> where T : IPrintable
    {
        public void PrintText(T txt)
        {
            txt.Print();
        }
    }
}
