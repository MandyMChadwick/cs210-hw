using System;

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //List<int> numbers = new List<int>();
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a Number ");
        while (true)

        {
            string userNumber = Console.ReadLine();
            if (int.TryParse(userNumber, out int intUserNumber))

            {
                if (intUserNumber == 0)
                {

                    break;
                }
                else

                {
                    Console.Write("Enter a number ");
                    numbers.Add(intUserNumber);
                }



            }
        }


        double numberAverage = numbers.Average();
        double numberSum = numbers.Sum();
        int numberMax = numbers.Max();
        Console.WriteLine($"The sum is: {numberSum}");
        Console.WriteLine($"The average is: {numberAverage}");
        Console.WriteLine($"The largest number is: {numberMax}");
    }
}
/*class Program
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
}*/