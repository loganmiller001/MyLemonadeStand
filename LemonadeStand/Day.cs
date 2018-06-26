using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public int Temperature { get; set; }
        public bool rain;
        public const int totalDays = 7;

        public Day()
        {
           
        }

        public virtual void SetTemperature()
        {

        }

        public virtual void DeterminePrecipitation()
        {

        }

        public virtual void CustomersApproaching()
        {

        }

        public virtual void RainAffectOnBuyers()
        {

        }

        public virtual void CustomersBuyLemonade()
        {

        }
    }
}
