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
            Console.WriteLine("Which supplies would you like to buy? Please write 'lemons', 'sugar', 'ice', or 'cups'. Write 'no' to leave the Shop. ");
            string userInput = Console.ReadLine();
            userInput.ToLower();
            switch (userInput)
            {
                case "lemons":
                    Console.WriteLine("How many lemons do you wish to buy?");
                    break;
                case "sugar":
                    Console.WriteLine("How much sugar do you wish to buy?");
                    break;
                case "ice":
                    Console.WriteLine("Hou much ice would you like to buy?");
                    break;
                case "cups":
                    Console.WriteLine("How many cups would you like to buy?");
                    break;
                case "no":
                    Console.WriteLine("Leaving shop now.");
                    break;
                default:
                    Console.WriteLine("Incorrect input, please choose again.");
                    ShopMenu();
                    break;
            }
        }

    }
}
