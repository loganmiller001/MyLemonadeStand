using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public Random random;
        public Day day;
        public Inventory inventory;
        public Player player;
        public Store store;
        public int AWeekLong;

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

        public void WeatherDisplay()
        {
            int AWeekLong = 7;
            Console.WriteLine("Your week long weather forcast: ");
            for (AWeekLong = 0; AWeekLong < 7; AWeekLong++)
            {
                DayMaker();
            }
           
        }
        public void GamePlay()
        {
            random = new Random();
            inventory = new Inventory();
            player = new Player();
            store = new Store();
           // DayMaker();
            PlayerInfo(player);
            PlayerInventory(inventory);
            BuyItems(store, inventory);
            Console.Clear();
            Console.WriteLine("Ready, press enter to begin the day.");
            Console.ReadLine();
            day.GenerateCustomers(random);
        }

        public void DayMaker()
        {
            day = new Day(random);
            
            
        }
        public void BuyItems(Store store, Inventory inventory)
        {
            store.BuyLemons(inventory);
            store.BuySugar(inventory);
            store.BuyIce(inventory);
            store.BuyCups(inventory);
            Console.Clear();
            inventory.DisplayInventory();
            inventory.CheckCash(inventory);
            Console.Clear();

        }

        public void PlayerInfo(Player player)
        {

            inventory.SetMoney();
            Console.ReadLine();
            Console.Clear();

        }

        public void PlayerInventory(Inventory inventory)
        {
            inventory.CheckCash(inventory);
            inventory.DisplayInventory();
            Console.ReadLine();
            Console.Clear();
        }

    }
}
