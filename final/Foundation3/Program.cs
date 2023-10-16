using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Lectures event
        Lectures lectureEvent = new Lectures("Lecture", "Bear Aware", "Learn about bear safety in Anchorage", "2023-10-30", "7:00 PM", "429 Denali street", "Mandy Chadwick", 99);

        // Display standard details
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.DisplayStandardDetail());

        // Display full details
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.DisplayFullDetail());

        // Display short details
        Console.WriteLine("\nShort Details:");
        Console.WriteLine(lectureEvent.DisplayShortDetail());

    }
}