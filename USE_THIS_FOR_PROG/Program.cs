using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USE_THIS_FOR_PROG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool addAnotherRecipe = true;
            while (addAnotherRecipe)
            {
                //ASKS USER TO ENTER NAME
                Console.WriteLine("Enter Recipe Name:");
                string recipeName = Console.ReadLine();
                //ASKS USER HOW MANY INGREDIENTS
                Console.WriteLine("How many ingredients?");
                int ingredientNumber = int.Parse(Console.ReadLine());

                List<string> ingredients = new List<string>();
                for (int i = 0; i < ingredientNumber; i++)
                {
                    //ENTER THE AMOUNT OF INGREDIENTS YOU ENTERED
                    Console.Write($"Enter Ingredient Name {i + 1}: ");
                    ingredients.Add(Console.ReadLine());
                }
                //ENTER THE MEASUREMENTS OF RECIPE
                Console.WriteLine("Enter recipe measurements (e.g., 1 cup, 250 grams, etc.):");
                string measureAmount = Console.ReadLine();
                Console.WriteLine("Measurements: " + measureAmount);

                double amount = double.Parse(measureAmount);
                //ENTER MEASUREMENT SCALING-0.5 only works with the number 1 for some reason
                Console.WriteLine("Enter scaling factor (e.g., 0.5, 2, 3):");
                double scalingAmount = double.Parse(Console.ReadLine());
                //SCALING AMOUNTS
                Console.WriteLine($"Scaled by {scalingAmount * 0.5}: {amount * (scalingAmount * 0.5)}");
                Console.WriteLine($"Scaled by {scalingAmount}: {amount * scalingAmount}");
                Console.WriteLine($"Scaled by {scalingAmount * 3}: {amount * (scalingAmount * 3)}");
                //RECIPE STEPS
                Console.WriteLine("How many steps?");
                int howManySteps = int.Parse(Console.ReadLine());

                string[] instructions = new string[howManySteps];
                Console.WriteLine("Recipe Instructions:");
                for (int i = 0; i < howManySteps; i++)
                {
                    Console.WriteLine("Step " + (i + 1) + ":");
                    instructions[i] = Console.ReadLine();
                }
                //INSTRUCTIONS AMOUNT DEPENDS ON NUMBER ENTERED INTO THE STEPS
                Console.WriteLine("Instructions:");
                foreach (var step in instructions)
                {
                    Console.WriteLine(step);
                }
                //RECIPE SUMMARY
                Console.WriteLine("--- Recipe Summary ---");
                Console.WriteLine("Recipe Name: " + recipeName);
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine("- " + ingredient);
                }
                Console.WriteLine("Steps:");
                foreach (var step in instructions)
                {
                    Console.WriteLine("- " + step);
                }
                //USER CAN ADD NEW RECIPE OR EXIT APPLICATION
                Console.WriteLine("Do you want to add another recipe? (yes/no)");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                {
                    //DO YOU WANT TO EXIT OR ADD ANOTHER RECIPE?
                    addAnotherRecipe = false;
                    Console.WriteLine("Press on keybaord to exit application........");
                    string endChoice = Console.ReadLine().ToLower();
                    if (endChoice == "yes")
                    {
                        //USER EXITS
                        Console.WriteLine("exited....");
                        break;
                    }
                }
            }
        }
    }
}


