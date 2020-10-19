using oop_week6_shoppingcart.Fruits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace oop_week6_shoppingcart
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple App1 = new Apple();
            Orange Ora = new Orange();
            Apple App2 = new Apple();
            Apple App3 = new Apple();

            IFruits[] checkout = new IFruits[4];

            double TotalCost(IFruits[] Fru)
            {
                double totpri = 0.0;
                for (int i = 0; i < Fru.Length; i++)
                {
                    totpri += Fru[i].Getprice(); //I don't understand how to use the get here
                }
                return (totpri);
            }
            TotalCost(checkout);
        }
    }
}
