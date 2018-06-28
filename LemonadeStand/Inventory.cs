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


         public Inventory()
        {

        }


        public void DisplayInventory()
        {

            Console.WriteLine($"Inventory: {lemons} lemons, {sugar} sugar, {ice} ice, {cups} cups.");
           

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
        }
    }
}
