using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Inventory inventory;
        public Player player;
        public Store store;

        public void RunGame()
        {
            StartMenu();
            GamePlay();
           

        }

        public void StartMenu()
        {
            Console.WriteLine("You will be running a lemonade stand for seven days, attempting to make as much revenue as possible.");
            Console.WriteLine("You will be able to purchase supplies such as lemons, sugar, ice, and cups before you start a new day and be able to set the price and amount of each you put into a single pitcher of lemonade.");
            Console.WriteLine("Use these to attempt to turn a profit and try and make as much money in one week as possilbe!");
            Console.ReadLine();
            

        }
        public void GamePlay()
        {
            inventory = new Inventory();
            player = new Player();
            store = new Store();
            PlayerInfo(player);
            PlayerInventory(inventory);
            BuyItems(store, inventory);
            Console.Clear();
        }

        public void BuyItems(Store store, Inventory inventory)
        {
            store.BuyLemons(inventory);
            store.BuySugar(inventory);
            store.BuyIce(inventory);
            store.BuyCups(inventory);
        }

        public void PlayerInfo(Player player)
        {

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Make changes to your recipe.");
            player.SetRecipe();

        }

        public void PlayerInventory(Inventory inventory)
        {
            inventory.SetMoney();
            inventory.DisplayInventory();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
