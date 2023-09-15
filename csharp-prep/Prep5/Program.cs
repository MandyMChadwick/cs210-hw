using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.Write("Please enter your name ");
        string yourName = Console.ReadLine();

        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();

        int intFavoriteNumber = int.Parse(favoriteNumber);
        int square = SquareNumbers(intFavoriteNumber);
        Console.Write($"{yourName}, the square of your number is {square}");


    }
    static int SquareNumbers(int intFavoriteNumber)
    {
        int square = intFavoriteNumber * intFavoriteNumber;
        return square;
    }

}


