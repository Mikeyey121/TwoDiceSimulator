using System.Xml.Linq;
using TwoDiceSimulator;

internal class Program
{
    private static void Main(string[] args)
    {
        int RollCount = 0;
        Class1 dice = new Class1();

        System.Console.WriteLine($"Welcome to the dice throwing simulator!\n");
        System.Console.Write($"How many dice rolls would you like to simulate? ");

        RollCount = int.Parse(System.Console.ReadLine());
        dice.RollDice(RollCount);

        //System.Console.WriteLine("Hello, World!");
    }
}