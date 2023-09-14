using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percent = Console.ReadLine();
        int intpercent = int.Parse(percent);

        string letter = "";

        if (intpercent >= 90)
        {
            letter = "A";
        }
        else if (intpercent >= 80)
        {
            letter = "B";
        }
        else if (intpercent >= 70)
        {
            letter = "C";
        }
        else if (intpercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (intpercent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Just Keep Trying!");
        }
    }
}