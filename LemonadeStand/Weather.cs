using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     public class Weather
    {
        
        public int condition;

        public Weather(Random random)
        {
            SetCondition(random);
        }
        
        public void SetCondition(Random random)
        {
            Random randomWeather = new Random();
            condition = randomWeather.Next(0, 10);

            if (condition <= 5)
            {
                Console.WriteLine("It is Sunny and Clear outside.");
                
            }
            else
            {
                Console.WriteLine("There is rain.");
            }

        }




    }
}
