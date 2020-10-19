using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_week6_shoppingcart.Fruits
{
    class Orange : IFruits
    {
        public double price { get; set; }

        public Orange()
        {
            price = 0.25;
        }
    }
}
