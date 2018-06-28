using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public Weather weather;
        public int percentChanceToBuy;

        public Customer(Random r)
        {
            percentChanceToBuy = r.Next(35, 65);
            ChanceBasedOnWeather(weather);

        }

        public void ChanceBasedOnWeather(Weather weather)
        {
            int min = 35;
            int max = 65;
            if (weather.condition <= 5)
            {
                min += 5;
                max += 10;
            }
            else
            {
                min -= 10;
                max -= 20;
            }
        }
    }
}
