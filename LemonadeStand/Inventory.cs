using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public int usedLemons;
        public int usedSugar;
        public int usedIce;
        public int usedCups;
        public double currentCash;
        public double moneyToAdd;
        public double moneyToRemove;
        public double losses;
        public double gains;
        public double currentProfitLoss;

         public Inventory()
        {

        }


        public void DisplayInventory()
        {

            Console.WriteLine($"Inventory: {lemons} lemons, {sugar} sugar, {ice} ice, {cups} cups.");
            Console.ReadLine();
           

        }

        public void ChangeRecipe()
        {
            Console.WriteLine("Enter how much of each item you'd like to add to your recipe.");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "yes":
                    SetRecipe(lemons, sugar, ice);
                    break;
                case "no":
                    break;
                default:
                    break;
            }

        }

        public void SetRecipe(int lemons, int sugar, int ice)
        {
            Console.WriteLine("Enter your choice of ingredients you wish to add. Type leave to exit the recipe maker.");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "lemons":
                    Console.WriteLine("How many lemons do you wish to add?");
                    int addLemons = Convert.ToInt32(Console.ReadLine());
                    int lostLemons = lemons - addLemons;
                    Console.WriteLine($"You have added {addLemons} lemons.");
                    SetRecipe(lemons, sugar, ice);
                    break;
                case "sugar":
                    Console.WriteLine("How much sugar do you wish to add?");
                    int addSugar = Convert.ToInt32(Console.ReadLine());
                    int lostSugar = sugar - addSugar;
                    Console.WriteLine($"You have added {addSugar} cups of sugar.");
                    SetRecipe(lemons, sugar, ice);
                    break;
                case "ice":
                    Console.WriteLine("How many cubes of ice do you wish to add?");
                    int addIce = Convert.ToInt32(Console.ReadLine());
                    int lostIce = ice - addIce;
                    Console.WriteLine($"You have added {addIce} cubes of ice.");
                    SetRecipe(lemons, sugar, ice);
                    break;
                case "leave":
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again.");
                    SetRecipe(lemons, sugar, ice);
                    break;
            }
        }

        public void RemoveItems(int usedLemons, int usedSugar, int usedIce, int usedCups)
        {
            int lostLemons = lemons - usedLemons;
            int lostSugar = sugar - usedSugar;
            int lostIce = ice - usedIce;
            int lostCups = cups - usedCups;
        }
        public double SetMoney()
        {
            return currentCash = 20.00;
            
        }

        public double AddMoney(double moneyToAdd, Inventory inventory)
        {
            inventory.currentCash = inventory.currentCash + moneyToAdd;
            return currentCash;
        }

        public double RemoveMoney(double moneyToRemove, Inventory inventory)
        {
            inventory.currentCash = inventory.currentCash - moneyToRemove;
            return currentCash;
        }
        
        public void CheckCash(Inventory inventory)
        {
            
            Console.WriteLine($"Your current cash is: {inventory.currentCash}");
            Console.ReadLine();
        }

        public double CalculateLoss(double moneyToRemove)
        {
            losses = losses + moneyToRemove;
            return losses;
          
        }

        public double CalculateProfit(double moneyToAdd)
        {
            gains = gains + moneyToAdd;
            return gains;
        }

        public void RunningProfit(Inventory inventory)
        {
            currentProfitLoss = gains - losses;
            Console.WriteLine($"Your current profit margin is: {inventory.currentProfitLoss}");
        }
    }
}
