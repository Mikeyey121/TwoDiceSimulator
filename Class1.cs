using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDiceSimulator
{
    internal class Class1
    {
        public void RollDice(int number)
        {
            int[] rolls = new int[] { 0,0,0,0,0,0,0,0,0,0,0 };
            Random rnd = new Random();
            for (int counter = 0; counter < number; counter++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1,7);
                int roll = roll1 + roll2;
                rolls[roll - 2] = rolls[roll - 2] + 1;
            }
            System.Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS \nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + number + ".\n");
            for (int counter = 0; counter < rolls.Length; counter++)
            {
                string asteriks = "";
                float percentage = ((float)rolls[counter] / number) * 100;
                for (int counter2 = 0; counter2 < percentage; counter2++)
                {
                    asteriks = asteriks + "*";
                }
                System.Console.WriteLine($"{counter + 2}: {asteriks}");

            }
            System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");

        }
    }
}
