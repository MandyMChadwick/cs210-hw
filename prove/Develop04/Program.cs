using System;
class Program
{
    // Simple menu to test out the game classes.
    static void Main(string[] args)
    {
        string choice = "0";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Your choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("you chose the breathing activity");
                //GuessingGame g = new GuessingGame();
                //g.Play();
            }
            else if (choice == "2")
            {
                Console.WriteLine("you chose the reflecting activity");
                // CodeWordGame g = new CodeWordGame();
                // g.Play();
            }
            else if (choice == "3")
            {
                Console.WriteLine("you chose the listing activity");
                // MathGame g = new MathGame();
                //g.Play();
            }
        }
        while (choice != "4");
        Console.WriteLine("Goodbye!");
    }
}