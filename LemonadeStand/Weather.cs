using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather : Day
    {
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
            else if (randomRain <=4)
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
