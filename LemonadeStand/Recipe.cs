using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int addLemons;
        public int addSugar;
        public int addIce;
        Inventory inventory;

        public Recipe()
        {

        }

        public void ChangeRecipe()
        {
            inventory = new Inventory();
            Console.WriteLine("Would you like to make changes to your recipe?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "yes":
                    SetRecipe(inventory);
                    break;
                case "no":
                    break;
                default:
                    break;
            }

        }

        public void SetRecipe(Inventory inventory)
        {
            Console.WriteLine("Enter your choice of ingredients you wish to add. Type leave to exit the recipe maker.");
            string userInput = Console.ReadLine().ToLower();
            switch (userInput)
            {
                case "lemons":
                    Console.WriteLine("How many lemons do you wish to add?");
                    int addLemons = Convert.ToInt32(Console.ReadLine());
                    int lostLemons = inventory.lemons - addLemons;
                    Console.WriteLine($"You have added {addLemons} lemons.");
                    SetRecipe(inventory);
                    break;
                case "sugar":
                    Console.WriteLine("How much sugar do you wish to add?");
                    int addSugar = Convert.ToInt32(Console.ReadLine());
                    int lostSugar = inventory.sugar - addSugar;
                    Console.WriteLine($"You have added {addSugar} cups of sugar.");
                    SetRecipe(inventory);
                    break;
                case "ice":
                    Console.WriteLine("How many cubes of ice do you wish to add?");
                    int addIce = Convert.ToInt32(Console.ReadLine());
                    int lostIce = inventory.ice - addIce;
                    Console.WriteLine($"You have added {addIce} cubes of ice.");
                    SetRecipe(inventory);
                    break;
                case "leave":
                    break;
                default:
                    Console.WriteLine("Wrong input, please try again.");
                    SetRecipe(inventory);
                    break;
            }
        }
    }
}
