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
            Random temperature = new Random();
            int randomTemperature = temperature.Next(minTemp, maxTemp);
            
        }
        


    }
}
