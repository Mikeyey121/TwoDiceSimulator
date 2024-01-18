// Michael Hutchings
// Section 2
// This program simulates the rolling of two die through the use of classes and methods

using System.Xml.Linq;
using TwoDiceSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        // Declaring the RollCount variable as an integer which will allow us to set it's value to a user's input later
        int RollCount = 0;

        // Setting an instance of our dice rolling class
        Class1 dice = new Class1();

        // Console logs to instruct the user
        System.Console.WriteLine($"Welcome to the dice throwing simulator!\n");
        System.Console.Write($"How many dice rolls would you like to simulate? ");

        // Setting the RollCount variable to whatever the user entered and then calling the RollDice method to perform our program
        RollCount = int.Parse(System.Console.ReadLine());
        dice.RollDice(RollCount);

    }
}