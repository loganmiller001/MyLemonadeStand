using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        public Weather weather;

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
            
            Console.WriteLine("The weather today is: ");
            
           DayMaker(weather); Thread.Sleep(500);
               
            
            Console.Clear();
        }
        public void GamePlay()
        {
            day = new Day(random);
            random = new Random();
            inventory = new Inventory();
            player = new Player();
            store = new Store();
            weather = new Weather();
            PlayerInfo(player);
            int AWeekLong = 7;
            for (AWeekLong = 0; AWeekLong < 7; AWeekLong++)
            {
                WeatherDisplay();
                PlayerInventory(inventory);
                BuyItems(store, inventory);
                day.SetPrice();
                Console.Clear();
                Console.WriteLine("Ready, press enter to begin the day.");
                Console.ReadLine();
                day.GenerateCustomers(random, weather);
                day.CalculateRevenue(inventory, day);
                GetProfit(inventory);
            } 

        }

        public void DayMaker(Weather weather)
        {

            Weather makeWeather = new Weather();
            makeWeather.SetTemp(random);
            makeWeather.SetRain(random, weather);
            
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
            player.GetUserInfo();
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
        public void GetProfit(Inventory inventory)
        {
            inventory.CalculateProfit(inventory.moneyToAdd);
            inventory.CalculateLoss(inventory.moneyToRemove);
            inventory.RunningProfit(inventory);
        }
    }
}
