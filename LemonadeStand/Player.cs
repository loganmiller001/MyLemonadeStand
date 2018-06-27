using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public int LemonCount { get; set; }
        public int IceCount { get; set; }
        public int SugarCount { get; set; }
        public int CupCount { get; set; }
        public int currentLemons;
        public int currentSugar;
        public int currentIce;
        public int currentCups;
        public int recipe;
        public double wallet;

        public Player()
        {
           
            
        }

        public void SetRecipe()
        {
            recipe = (LemonCount) + (SugarCount) + (IceCount);
            Console.WriteLine("Please enter the amount of lemons, sugar and ice you want to use per cup.");

        }

        public virtual void DisplayInventory()
        {
            Console.WriteLine("You currently have: Lemons: " + currentLemons + "Sugar: " + currentSugar + "Ice: " + currentIce + "Cups: " + currentCups);
        }

        public virtual void SetStartingMoney()
        {
            
        }
    }
}
