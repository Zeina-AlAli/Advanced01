using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class AnimalContainer<T> where T : Animal
    {
        public void  Feed(T animal)
        {
            animal.Eat();
        }
    }
}
