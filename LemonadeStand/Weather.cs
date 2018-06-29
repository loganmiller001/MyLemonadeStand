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
        public string conditions;

        public Weather()
        {

        }
        
        public void SetRain(Random random, Weather weather)
        {
            Weather getWeather = new Weather();
            Random randomWeather = new Random();
            condition = randomWeather.Next(0, 10);
            string conditions = Console.ReadLine().ToString();
            

            if (condition <= 5)
            {
                Console.WriteLine("It is Clear outside.");
                getWeather.conditions= Console.ReadLine().ToString();
                
            }
            else
            {
                Console.WriteLine("There is rain.");
                getWeather.conditions = Console.ReadLine().ToString();
            }
            

        }

        public void SetTemp(Random random)
        {
            Weather getWeather = new Weather();
            Random randomTemperature = new Random();
            getWeather.temperature = randomTemperature.Next(65, 99);

            if (getWeather.temperature <= 80)
            {
                Console.WriteLine($"It is {getWeather.temperature} and warm outside");
            }
            else
            {
                Console.WriteLine($"It is {getWeather.temperature} and scalding outside!");
            }
            
        }




    }
}
