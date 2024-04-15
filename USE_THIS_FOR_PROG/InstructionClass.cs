using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USE_THIS_FOR_PROG
{
    internal class InstructionClass
    {
        public string[] GetInstructions(int howManySteps)
        {
            //RECIPE INSTRUCTIONS
            string[] instructions = new string[howManySteps];
            Console.WriteLine("Recipe Instructions:");
            for (int i = 0; i < howManySteps; i++)
            {
                //DISPLAY STEPS.
                Console.WriteLine("Step " + (i + 1) + ":");
                instructions[i] = Console.ReadLine();
            }
            return instructions;
        }
    }
}

