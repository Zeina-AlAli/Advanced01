using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Document : IPrintable
    {
        public Document() { }
        public void Print() 
        { Console.WriteLine("Document is printed."); }

    }
}
