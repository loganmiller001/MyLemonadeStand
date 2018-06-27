using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        public int lemons;
        public int sugar;
        public int ice;
        public int cups;
        public double cash = 20.00;
        public bool enoughInventory;



         public Inventory()
        {

        }


        public void DisplayInventory()
        {

            Console.WriteLine($"Inventory: {lemons} lemons, {sugar} sugar, {ice} ice, {cups} cups.");
           

        }

        public void ShowMoney()
        {

            Console.WriteLine($"You have ${cash}. ");
        }


    }
}
