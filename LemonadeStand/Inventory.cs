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
        public double cash = 20.00;
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

        public void SetMoney()
        {
           
            Console.WriteLine($"You have ${cash}. ");
        }

        public double AddMoney(double moneyToAdd, Inventory inventory)
        {
            double currentCash = cash + moneyToAdd;
            return currentCash;
        }

        public double RemoveMoney(double moneyToRemove, Inventory inventory)
        {
            double currentCash = cash - moneyToRemove;
            return currentCash;
        }
        
        public void CheckCash()
        {
            Console.WriteLine($"Your current cash is: {currentCash}");
        }
    }
}
