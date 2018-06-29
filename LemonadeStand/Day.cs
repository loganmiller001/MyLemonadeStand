using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public List<Customer> customers;
        public Weather weather;
        public Recipe recipe;
        public const int totalDays = 7;

        public Day(Random rnd)
        {
            customers = new List<Customer>();
            weather = new Weather(rnd);
            recipe = new Recipe();
            


        }

        public void GenerateCustomers(Random rnd)
        {
            int min = 150;
            int max = 300;

            if(weather.condition <= 5)
            {
                min += 10;
                max += 25;
            }
            else
            {
                min -= 20;
                max -= 40;
            }
            int numberOfCustomers = rnd.Next(min, max);

           // for (int i = 0; i < numberOfCustomers; i++)
         //   {
                customers.Add(new Customer(rnd));
                Console.WriteLine($"You have had {numberOfCustomers} customers buy lemonade!");
          //  }
        }
    }

}

       