using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
     class Weather : Day
    {
        public int weatherType;
        private const int maxTemp = 100;
        private const int minTemp = 50;

        private Weather(int Temperature)
        {
            this.Temperature = Temperature;

        }
        
        
        public override void  SetTemperature()
        {
            base.SetTemperature();

            
            Random temperature = new Random();
            int randomTemperature = temperature.Next(minTemp, maxTemp);
            if (randomTemperature <= 74)
            {
                weatherType = 1;
                Console.WriteLine("Weather is cool and breezy.");
            }
            else if (randomTemperature == 75)
            {
                weatherType = 2;
                Console.WriteLine("Weather is warm.");
            }
            else if (randomTemperature <=89)
            {
                weatherType = 3;
                Console.WriteLine("It is hot outside!");
            }
            else
            {
                weatherType = 4;
                Console.WriteLine("The weather is scalding!");
            }
        }

        public override void DeterminePrecipitation()
        {
            base.DeterminePrecipitation();

            Random rain = new Random();
            int randomRain = rain.Next(0, 5);

            if(randomRain >= 2)
            {
                Console.WriteLine("It is raining!");
            }
            else if (randomRain <= 4)
            {
                Console.WriteLine("It is not raining.");
            }
            else
            {
                Console.WriteLine("There is a slight overcast.");
            }
        }



    }
}
