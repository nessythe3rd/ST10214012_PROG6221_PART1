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
                Console.WriteLine("Enter Recipe Name:");
                string recipeName = Console.ReadLine();

                Console.WriteLine("How many ingredients?");
                int ingredientNumber = int.Parse(Console.ReadLine());

                List<string> ingredients = new List<string>();
                for (int i = 0; i < ingredientNumber; i++)
                {
                    Console.Write($"Enter Ingredient Name:{i + 1}: ");
                    ingredients.Add(Console.ReadLine());
                }

                Console.WriteLine("Enter recipe measurements (e.g., 1 cup, 250 grams, etc.):");
                string measureAmount = Console.ReadLine();
                Console.WriteLine("Measurements: " + measureAmount);

                double amount = double.Parse(measureAmount);

                Console.WriteLine("Enter scaling factor (e.g., 0.5, 2, 3):");
                double scalingAmount = double.Parse(Console.ReadLine());

                Console.WriteLine($"Scaled by {scalingAmount * 0.5}: {amount * (scalingAmount * 0.5)}");
                Console.WriteLine($"Scaled by {scalingAmount}: {amount * scalingAmount}");
                Console.WriteLine($"Scaled by {scalingAmount * 3}: {amount * (scalingAmount * 3)}");

                Console.WriteLine("How many steps?");
                int howManySteps = int.Parse(Console.ReadLine());

                string[] instructions = new string[howManySteps];
                Console.WriteLine("Recipe Instructions:");
                for (int i = 0; i < howManySteps; i++)
                {
                    Console.WriteLine("Step " + (i + 1) + ":");
                    instructions[i] = Console.ReadLine();
                }

                Console.WriteLine("Instructions:");
                foreach (var step in instructions)
                {
                    Console.WriteLine(step);
                }

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

                Console.WriteLine("Do you want to add another recipe? (yes/no)");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                {
                    addAnotherRecipe = false;
                    Console.WriteLine("Do you want to end the program? (yes/no)");
                    string endChoice = Console.ReadLine().ToLower();
                    if (endChoice == "yes")
                    {
                        Console.WriteLine("Program ended.");
                        break;
                    }
                }
            }
        }
    }
}


