using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced01
{
    internal class ProductRepository : IRepository<string>
    {
        public string product { get; set; }
        
        public void Add(string product)
        {
          this.product = product;
            Console.WriteLine($"{product} is added.");
        }
        public string Get()
        {
            return product ;
        }

    }
}
