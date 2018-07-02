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
        public double price;
        public int numberOfCustomers;
        public int lostCups;

        public Day(Random rnd)
        {
            customers = new List<Customer>();



        }

        public int GenerateCustomers(Random rnd, Weather weather)
        {

            int min = 50;
            int max = 125;

            if (weather.condition <= 5)
            {
                min += 10;
                max += 25;
            }
            else
            {
                min -= 20;
                max -= 40;
            }
            numberOfCustomers = rnd.Next(min, max);
            customers.Add(new Customer(rnd));
            return numberOfCustomers;

        }
        public double SetPrice()
        {
            Console.WriteLine("Please type out the price you want to set your Lemonade.");
            double userInput = Convert.ToDouble(Console.ReadLine());
            price = userInput;
            return price;

        }
        public void CalculateRevenue(Inventory inventory, Day day)
        {
            double moneyToAdd = price * numberOfCustomers;
            Console.WriteLine($"You have had {numberOfCustomers} customers buy lemonade for ${moneyToAdd}");
            inventory.AddMoney(moneyToAdd, inventory);
            inventory.CalculateProfit(moneyToAdd);
        }

    }
}


       