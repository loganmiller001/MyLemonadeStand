using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {

        public double buyLemons;
        public double buyIce;
        public double buySugar;
        public double buyCups;
        public double price;
        public double moneySpent;
        public Inventory inventory;
        



        public Store()
        {

        }



        public void BuyLemons(Inventory inventory)
        {
            Console.WriteLine("Would you like to buy lemons?");
            string userInput = Console.ReadLine().ToLower();
            double price = .25;
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine($"Lemons cost: {price} How many lemons would you like to buy?");
                    double buyLemons = Convert.ToDouble(Console.ReadLine());
                    double moneyToRemove = buyLemons * price;
                    Console.WriteLine($"You have bought {buyLemons} lemons for ${moneyToRemove}");
                    Console.ReadLine();
                    inventory.RemoveMoney(moneyToRemove, inventory );
                    inventory.lemons = Convert.ToInt32(inventory.lemons + buyLemons );
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
            double price = .21;
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine($"Sugar costs: ${price}. How much sugar do you wish to buy?");
                    double buySugar = Convert.ToDouble(Console.ReadLine());
                    double moneyToRemove = buySugar * price;
                    Console.WriteLine($"You have bought: {buySugar} sugar for ${moneyToRemove}. ");
                    Console.ReadLine();
                    inventory.RemoveMoney(moneyToRemove, inventory);
                    inventory.sugar = Convert.ToInt32(inventory.sugar + buySugar);
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
            double price = .20;
            switch (userInput)
            {
                case "yes":
                    Console.WriteLine($"Ice costs ${price}. How much ice would you like to buy?");
                    double buyIce = Convert.ToDouble(Console.ReadLine());
                    double moneyToRemove = buyIce * price;
                    Console.WriteLine($"You have bought {buyIce} ice for ${moneyToRemove}");
                    Console.ReadLine();
                    inventory.RemoveMoney(moneyToRemove, inventory);
                    inventory.ice = Convert.ToInt32(inventory.ice + buyIce);
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
            double price = .10;
            switch (userInput)
            {

                case "yes":
                    Console.WriteLine($"Cups cost {price}. How many cups would you like to buy?");
                    double buyCups = Convert.ToDouble(Console.ReadLine());
                    double moneyToRemove = buyCups * price;
                    Console.WriteLine($"You have bought {buyCups} cups for ${moneyToRemove}.");
                    Console.ReadLine();
                    inventory.RemoveMoney(moneyToRemove, inventory);
                    inventory.cups = Convert.ToInt32(inventory.cups + buyCups);
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
