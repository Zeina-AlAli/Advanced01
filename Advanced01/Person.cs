using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class Person<T> where T : new()
    {
        public T Name { get; set; }
        public T create()
        { Console.WriteLine("New Person is Created"); return new T(); }
    }
}
