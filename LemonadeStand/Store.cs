using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {

        public int lemons;
        public int ice;
        public int sugar;
        public int cups;
        public int lemonsCost;
        public int iceCost;
        public int sugarCost;
        public int cupsCost;

        public Store()
        {

        }

        public void ShopMenu()
        {
            Console.WriteLine("Which supplies would you like to buy? Please write 'lemons', 'sugar', 'ice', or 'cups' ");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            switch (userInput)
            {
                case "lemons":
                    Console.WriteLine("");
                    break;
                case "sugar":

                    break;
                case "ice":

                    break;
                case "cups":

                    break;
                default:
                    Console.WriteLine("Incorrect input, please choose again.");
                    ShopMenu();
                    break;
            }
        }

    }
}
