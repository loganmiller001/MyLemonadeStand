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
            

        }

        public void ChanceBasedOnWeather(Weather weather)
        {
            int min = 35;
            int max = 65;
            if (weather.condition <= 5 && weather.temperature >= 80)
            {
                min += 20;
                max += 30;
            }
            else if (weather.condition <= 5 && weather.temperature <= 80)
            {
                min += 10;
                max += 15;
            }
            else if (weather.condition >= 5 && weather.temperature >= 80) 
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
