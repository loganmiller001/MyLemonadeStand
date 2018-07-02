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
        public double currentCash;
        public double moneyToAdd;
        public double moneyToRemove;
        public double losses;
        public double gains;
        public double currentProfitLoss;
        public int lostCups;
        public int lostLemons;
        public int lostIce;
        public int lostSugar;
        Recipe recipe;

         public Inventory()
        {

        }


        public void DisplayInventory()
        {

            Console.WriteLine($"Inventory: {lemons} lemons, {sugar} sugar, {ice} ice, {cups} cups.");
            Console.ReadLine();
           

        }
 

        public void RemoveItems(Recipe recipe)
        {
            int lostLemons = lemons - recipe.addLemons;
            int lostSugar = sugar - recipe.addSugar;
            int lostIce = ice - recipe.addIce;
        }

        public void RemoveCups(Day day)
        {
            int lostCups = cups - day.lostCups;
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
