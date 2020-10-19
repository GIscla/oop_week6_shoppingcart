using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_week6_shoppingcart.Fruits
{
    class Apple : IFruits
    {
        public double price { get; set; }

        public Apple()
        {
            price = 0.6;
        }
    }
}
