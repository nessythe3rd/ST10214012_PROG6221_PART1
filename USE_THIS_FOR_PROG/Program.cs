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
            //USER MUST ENTER RECIPE NAME
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
                //USER MUST NOW ENTER THE NAME OF ENGREDIENTS
                Console.Write($"Enter Ingredient Name:{i + 1}: ");
                ingredients.Add(Console.ReadLine());
                Console.WriteLine();
            }
            //USER MUST NOW ENTER THE MEASUREMONTS OF THESE ENGREDIENTS
            Console.WriteLine("Enter recipe measurements (e.g., 1 cup, 250 grams, etc.):");
            string measureAmount = Console.ReadLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Measurements: " + measureAmount);
            Console.WriteLine("-------------------");

            Console.WriteLine();
            double amount = double.Parse(measureAmount);
            //SCALE THE NEASUREMENT AMMOUNT-0.5 only works when 1 is typed and not 0.5
            Console.WriteLine("Enter scaling factor (e.g., 0.5, 2, 3):");
            double scalingAmount = double.Parse(Console.ReadLine());

            //SCALING
            Console.WriteLine($"Scaled by {scalingAmount * 0.5}: {amount * (scalingAmount * 0.5)}");
            Console.WriteLine($"Scaled by {scalingAmount}: {amount * scalingAmount}");
            Console.WriteLine($"Scaled by {scalingAmount * 3}: {amount * (scalingAmount * 3)}");

          //USER MUST ENTER THE AMOUNT OF STEPS
            Console.WriteLine("How many steps?");
            Console.WriteLine("-------------------");
            int howManySteps = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");

            string[] instructions = new string[howManySteps];
            //USER MUST ENTER THE INSTRUCTION OF HOW THE RECIPE MUST BE MADE
            Console.WriteLine("Recipe Instructions:");
            for (int i = 0; i < howManySteps; i++)
            {
                Console.WriteLine("Step " + (i + 1) + ":");
                instructions[i] = Console.ReadLine();
            }
            //DISPLAY THOSE INSTRUCTIONS
            Console.WriteLine("Instructions:");
            foreach (var step in instructions)
            {
                Console.WriteLine(step);
            }
            //RECIPE SUMMARY
            Console.WriteLine("-------------------");
            Console.WriteLine("Recipe Summary");
            Console.WriteLine("Recipe Name: " + recipeName);
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine("- " + ingredient);
            }
            Console.WriteLine("How To Make:");
            foreach (var step in instructions)
            {
                Console.WriteLine("- " + step);
                Console.WriteLine("-------------------");

            }

            Console.ReadLine();
           
        }
    }
}


 


