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
        public int minTemp = 65;
        public int maxTemp = 99;
        public int temperature;

        public Weather(Random random)
        {
            SetRain(random);
            SetTemp(random);
        }
        
        public void SetRain(Random random)
        {
            Random randomWeather = new Random();
            condition = randomWeather.Next(0, 10);

            if (condition <= 5)
            {
                Console.WriteLine("It is Clear outside.");
                
            }
            else
            {
                Console.WriteLine("There is rain.");
            }

        }

        public void SetTemp(Random random)
        {
            Random randomTemperature = new Random();
            temperature = randomTemperature.Next(65, 99);

            if (temperature <= 80)
            {
                Console.WriteLine($"It is {temperature} and warm outside");
            }
            else
            {
                Console.WriteLine($"It is {temperature} and scalding outside!");
            }
        }




    }
}
