using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer : Day
    {
        private int totalCustomers = 500;
        private int weatherType;
        private int randomRain;
        private int lostCustomersDueToRain;
        private int randomCustomers;
        private int payingCustomers;

        public Customer()
        {
            

        }

        public override void CustomersApproaching()
        {
            base.CustomersApproaching();

            if (weatherType == 1)
            {
                totalCustomers = 150;
                Random customers = new Random();
                int randomCustomers = customers.Next(10, 150);
            }
            else if (weatherType == 2)
            {
                totalCustomers = 250;
                Random customers = new Random();
                int randomCustomers = customers.Next(20, 200);
            }
            else if (weatherType == 3)
            {
                totalCustomers = 350;
                Random customers = new Random();
                int randomCustomers = customers.Next(35, 350);
            }
            else
            {
                totalCustomers = 500;
                Random customers = new Random();
                int randomCustomers = customers.Next(50, 500);
            }
            
            
        }

        public override void RainAffectOnBuyers()
        {
            base.RainAffectOnBuyers();

            if(randomRain >= 2)
            {
                lostCustomersDueToRain = 35;
                payingCustomers -= lostCustomersDueToRain;
            }
            else if(randomRain == 3)
            {
                lostCustomersDueToRain = 15;
                payingCustomers -= lostCustomersDueToRain;
            }
            else
            {
                lostCustomersDueToRain = 0;
            }
        }

        public override void CustomersBuyLemonade()
        {
            base.CustomersBuyLemonade();

            if (randomCustomers == 150)
            {
                Random randomCustomers = new Random();
                int payingCustomers = randomCustomers.Next(0, 150);
            }
            else if (randomCustomers == 250)
            {
                Random randomCustomers = new Random();
                int payingCustomers = randomCustomers.Next(0, 250);
            }
            else if (randomCustomers == 350)
            {
                Random randomCustomers = new Random();
                int payingCustomers = randomCustomers.Next(0, 350);
            }
            else
            {
                Random randomCustomers = new Random();
                int payingCustomers = randomCustomers.Next(0, 500);
            }
        }





    }
}
