using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public string playerName;

        public Player()
        {
            playerName = GetUserInfo();
            
        }

        public string GetUserInfo()
        {
            Console.WriteLine("What is your Name?");
            playerName = Console.ReadLine();
            return playerName;
        }

        public void SetRecipe()
        {
            Console.WriteLine("Enter how many of each ingredients you wish to add to make your lemonade.");
            string userInput = Console.ReadLine().ToLower();

        }


    }
}
