using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        public int getLemons;
        public int getIce;
        public int getSugar;
        public int getCups;
        public double price;
        public double moneySpent;



        public Store()
        {

        }



        public void BuyLemons()
        {
            Console.WriteLine("Would you like to buy lemons?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("How many lemons would you like to buy?");
                    int getLemons = Int32.Parse("");
                    Console.WriteLine($"You have bought: {getLemons} lemons.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong input, please type 'yes' or 'no'. ");
                    BuyLemons();
                    break;
            }


        }

        public void BuySugar()
        {
            Console.WriteLine("Would you like to buy sugar?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("How much sugar do you wish to buy?");
                    int getSugar = Int32.Parse("");
                    Console.WriteLine($"You have bought: {getSugar} sugar.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong user input, please type 'yes' or 'no'.");
                    BuySugar();
                    break;
            }


        }

        public void BuyIce()
        {
            Console.WriteLine("Would you like to buy ice?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine("How much ice would you like to buy?");
                    int getIce = Int32.Parse("");
                    Console.WriteLine($"You have bought {getIce} ice.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong input, please type 'yes' or 'no'.");
                    break;
            }
        }

        public void BuyCups()
        {
            Console.WriteLine("Would you like to buy cups?");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {

                case "yes":
                    Console.WriteLine("How many cups would you like to buy?");
                    int getCups = Int32.Parse("");
                    Console.WriteLine($"You have bought {this.getCups} cups.");
                    break;
                case "no":
                    break;
                default:
                    Console.WriteLine("Wrong input, please type 'yes' or 'no'.");
                    break;
            }

        }
    }
}
