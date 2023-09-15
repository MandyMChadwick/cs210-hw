using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        Console.WriteLine($"What is the magic number? {number}");
        Console.Write($"What is your guess? ");

        while (true)
        {
            string guess = Console.ReadLine();
            if (int.TryParse(guess, out int intGuess))
            {
                if (number == intGuess)
                {
                    Console.Write("You Guessed it!");
                    break;
                }
                else if (number > intGuess)
                {
                    Console.Write("Too low, try again ");
                }
                else
                {
                    Console.Write("Too high, try again ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
