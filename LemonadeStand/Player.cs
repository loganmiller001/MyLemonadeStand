using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public string playerName;
        public double userInput;

        public Player()
        {
            
        }

        public string GetUserInfo()
        {
            Console.WriteLine("What is your Name?");
            playerName = Console.ReadLine();
            return playerName;
        }


    }
}
