using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPizzaNunit
{
    public class PizzaNu
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public decimal Price { get; set; }
        public object HashCode { get; private set; }

        public PizzaNu(string name, int size, decimal price)
        {
            Name = name;
            Size = size;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            if (obj is PizzaNu otherPizza)
            {
                return Name == otherPizza.Name &&
                       Size == otherPizza.Size &&
                       Price == otherPizza.Price;
            }
            return false;
        }

      
     
    }

}

