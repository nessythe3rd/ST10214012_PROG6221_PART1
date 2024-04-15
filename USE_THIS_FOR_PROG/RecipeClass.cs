using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USE_THIS_FOR_PROG
{
    internal class RecipeClass
    {
        //RECIPE CLASS-ALL RECIPE RELATED CODE
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                //USER IS ASKED TO ENTER RECIPE NAME
                Console.WriteLine("Enter Recipe Name:");
                string recipeName = Console.ReadLine();
                Console.WriteLine("-------------------");
                Console.WriteLine("Recipe Name: " + recipeName);
                Console.WriteLine("-------------------");
                //USER MUST ENTER THE AMOUNT OF INGREDIENTS
                Console.WriteLine();
                Console.WriteLine("How many ingredients?");
                Console.WriteLine("-------------------");
                int ingredientNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------");

                List<string> ingredients = new List<string>();
                for (int i = 0; i < ingredientNumber; i++)
                {
                    //ENTER THE NAME IF INGREDIENTS-AMOUNT WILL CHANGE BASED ON INPUT
                    Console.Write($"Enter Ingredient Name {i + 1}: ");
                    ingredients.Add(Console.ReadLine());
                    Console.WriteLine();
                }
                //USER MUST ENTER THE MEASUREMENTS
                Console.WriteLine("Enter recipe measurements (e.g., 1 cup, 250 grams, etc.):");
                string measureAmount = Console.ReadLine();
                Console.WriteLine("-------------------");
                //MEASUREMENTS DISPLAY
                Console.WriteLine("Measurements: " + measureAmount);
                Console.WriteLine("-------------------");

                Console.WriteLine();
                double amount = double.Parse(measureAmount);
                //SCALE THE MEASUREMENTS-0,5 only works when 1 is entered.
                Console.WriteLine("Enter scaling factor (e.g., 0.5, 2, 3):");
                double scalingAmount = double.Parse(Console.ReadLine());

                Console.WriteLine($"Scaled by {scalingAmount * 0.5}: {amount * (scalingAmount * 0.5)}");
                Console.WriteLine($"Scaled by {scalingAmount}: {amount * scalingAmount}");
                Console.WriteLine($"Scaled by {scalingAmount * 3}: {amount * (scalingAmount * 3)}");
                //RECIPE STEPS AMOUNT
                Console.WriteLine("How many steps?");
                Console.WriteLine("-------------------");
                int howManySteps = int.Parse(Console.ReadLine());
                Console.WriteLine("-------------------");

                InstructionClass instructionManager = new InstructionClass();
                string[] instructions = instructionManager.GetInstructions(howManySteps);
                //USER MUST ENTER HOW THE RECIPE MUST BE MADE
                Console.WriteLine("Instructions:");
                foreach (var step in instructions)
                {
                    Console.WriteLine("- " + step);
                }
                //SUMMARY OF STEPS
                Console.WriteLine("-------------------");
                Console.WriteLine("Recipe Summary");
                Console.WriteLine("Recipe Name: " + recipeName);
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in ingredients)
                {
                    Console.WriteLine("- " + ingredient);
                }
                //SUMMRAY OF HOW THE RECIPE IS MADE-STEPS TO THE RECIPE
                Console.WriteLine("How To Make:");
                foreach (var step in instructions)
                {
                    Console.WriteLine("- " + step);
                    Console.WriteLine("-------------------");
                }
                //USER CAN ADD NEW RECIPE OR EXIT APPLICATION
                Console.WriteLine("1. Add a new recipe");
                Console.WriteLine("2. Exit the app");
                Console.WriteLine("Choose an option:");
                string choice = Console.ReadLine();
                if (choice == "2")
                {
                    exit = true;
                }
               
                Console.Clear(); 
                //*******************************END OF FILE*****************************************************
            }
        }
    }
}

