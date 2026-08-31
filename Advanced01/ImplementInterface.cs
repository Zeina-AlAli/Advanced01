using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class ImplementInterface : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        
    }
}
