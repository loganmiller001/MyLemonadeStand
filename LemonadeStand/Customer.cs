using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int totalCustomers = 500;
        public int weatherType;
        public int randomRain;
        public int lostCustomersDueToRain;
        public int randomCustomers;
        public int payingCustomers;

        public Customer()
        {
            

        }

        public void CustomersApproaching()
        {

            if (weatherType == 1)
            {
                totalCustomers = 150;
                Random customers = new Random();
                randomCustomers = customers.Next(30, 150);
            }
            else if (weatherType == 2)
            {
                totalCustomers = 250;
                Random customers = new Random();
                randomCustomers = customers.Next(50, 250);
            }
            else if (weatherType == 3)
            {
                totalCustomers = 350;
                Random customers = new Random();
                randomCustomers = customers.Next(75, 350);
            }
            else
            {
                totalCustomers = 500;
                Random customers = new Random();
                randomCustomers = customers.Next(100, 500);
            }
            
            
        }

        public void RainAffectOnBuyers()
        {

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

        public void CustomersBuyLemonade()
        {

            if (randomCustomers == 150)
            {
                Random randomCustomers = new Random();
                payingCustomers = randomCustomers.Next(0, 150);
            }
            else if (randomCustomers == 250)
            {
                Random randomCustomers = new Random();
                payingCustomers = randomCustomers.Next(0, 250);
            }
            else if (randomCustomers == 350)
            {
                Random randomCustomers = new Random();
                payingCustomers = randomCustomers.Next(0, 350);
            }
            else
            {
                Random randomCustomers = new Random();
                payingCustomers = randomCustomers.Next(0, 500);
            }
        }





    }
}
