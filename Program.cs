// Michael Hutchings
// Section 2
// This program simulates the rolling of two die through the use of classes and methods

using System.Xml.Linq;
using TwoDiceSimulator;

// Declaring the RollCount variable as an integer which will allow us to set it's value to a user's input later

// Setting an instance of our dice rolling class
Class1 dice = new Class1();

// Console logs to instruct the user
System.Console.WriteLine($"Welcome to the dice throwing simulator!\n");

// Using a boolean variable for the while loop for error handling
bool continueLoop = true;

while (continueLoop)
{
    System.Console.Write($"How many dice rolls would you like to simulate? ");
    string input = Console.ReadLine();
    int RollCount;

    if (int.TryParse(input, out RollCount))
    {
        // Setting the RollCount variable to whatever the user entered and then calling the RollDice method to perform our program
        dice.RollDice(RollCount);
        continueLoop = false;
    }
    else
    {
        Console.WriteLine("Please enter a valid number.");
    }

}
