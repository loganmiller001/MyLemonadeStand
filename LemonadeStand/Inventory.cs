using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory:Player
    {
        private int inventoryCount;
        private double startMoney;
        private double currentMoney;

         Inventory(int lemons, int sugar, int ice, int cups)
        {
            this.LemonCount = lemons;
            this.SugarCount = sugar;
            this.IceCount = ice;
            this.CupCount = cups;
        }


        public override void DisplayInventory()
        {
            base.DisplayInventory();
            inventoryCount = (LemonCount + SugarCount + IceCount + CupCount);
            
        }

        public override void SetStartingMoney()
        {
            base.SetStartingMoney();

            startMoney = 20.00;
            Console.WriteLine("You Have : $" +startMoney);
        }


    }
}
