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
            double TotalCost(IFruits[] Fru)
            {
                double totpri = 0.0;
                for (int i = 0; i < Fru.Length; i++)
                {
                    totpri += Fru[i].price;
                }
                return (totpri);
            }

            Apple App1 = new Apple();
            Orange Ora = new Orange();
            Apple App2 = new Apple();
            Apple App3 = new Apple();

            IFruits[] checkout = new IFruits[4];
            checkout[0] = App1;
            checkout[1] = Ora;
            checkout[2] = App2;
            checkout[3] = App3;

            Console.WriteLine(TotalCost(checkout));
            Console.ReadLine();

        }
    }
}
