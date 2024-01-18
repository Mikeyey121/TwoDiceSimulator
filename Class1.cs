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
            // Declaring the integer list which will be added to later from the rolls
            int[] rolls = new int[] { 0,0,0,0,0,0,0,0,0,0,0 };

            // Creating an instance of the Random class and then using it to simulate the rolling of two dice
            // It will roll two dice for as many times as the user has entered
            // It will also keep track of how many of each number was rolled using our rolls list
            Random rnd = new Random();
            for (int counter = 0; counter < number; counter++)
            {
                int roll1 = rnd.Next(1, 7);
                int roll2 = rnd.Next(1,7);
                int roll = roll1 + roll2;
                rolls[roll - 2] = rolls[roll - 2] + 1;
            }

            // Output which displays the percentage of results to the user
            // The for loops will print each number that can be rolled with two dice
            // And then it will print out the percentage out of the total that were that specific number
            // It does this using asteriks
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
            System.Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!\n\n");

        }
    }
}
