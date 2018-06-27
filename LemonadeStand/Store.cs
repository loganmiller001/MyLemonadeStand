using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {

        public string buyLemons;
        public string buyIce;
        public string buySugar;
        public string buyCups;
        public int getLemons;
        public int getIce;
        public int getSugar;
        public int getCups;
        public double price;
        public double moneySpent;
        



        public Store()
        {

        }



        public void BuyLemons(Inventory inventory)
        {
            Console.WriteLine("Would you like to buy lemons?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("How many lemons would you like to buy?");
                    string buyLemons = Console.ReadLine();
                    int getLemons = Int32.Parse($"{buyLemons}");
                    Console.WriteLine($"You have bought: {getLemons} lemons.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong input, please type 'yes' or 'no'. ");
                    BuyLemons(inventory);
                    break;
            }


        }

        public void BuySugar(Inventory inventory)
        {
            Console.WriteLine("Would you like to buy sugar?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("How much sugar do you wish to buy?");
                    string buySugar = Console.ReadLine();
                    int getSugar = Int32.Parse($"{buySugar}");
                    Console.WriteLine($"You have bought: {getSugar} sugar.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong user input, please type 'yes' or 'no'.");
                    BuySugar(inventory);
                    break;
            }


        }

        public void BuyIce(Inventory inventory)
        {
            Console.WriteLine("Would you like to buy ice?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("How much ice would you like to buy?");
                    string buyIce = Console.ReadLine();
                    int getIce = Int32.Parse($"{buyIce}");
                    Console.WriteLine($"You have bought {getIce} ice.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong input, please type 'yes' or 'no'.");
                    BuyIce(inventory);
                    break;
            }
        }

        public void BuyCups(Inventory inventory)
        {
            Console.WriteLine("Would you like to buy cups?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {

                case "yes":
                    Console.WriteLine("How many cups would you like to buy?");
                    string buyCups = Console.ReadLine();
                    int getCups = Int32.Parse($"{buyCups}");
                    Console.WriteLine($"You have bought {getCups} cups.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong input, please type 'yes' or 'no'.");
                    BuyCups(inventory);
                    break;
            }

        }
    }
}
