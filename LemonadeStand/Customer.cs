using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int percentChanceToBuy;

        public Customer(Random r)
        {
            percentChanceToBuy = r.Next(35, 65);

        }

        public void ChanceBasedOnWeather()
        {

        }
    }
}
