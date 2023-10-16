using System;

class Program
{
    static void Main(string[] args)
    {

        Lectures lectureEvent = new Lectures("Lecture", "Bear Aware", "Learn about bear safety in Anchorage", "2023-10-30", "7:00 PM", "429 Denali street", "Mandy Chadwick", 99);


        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.DisplayStandardDetail());

        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.DisplayFullDetail());


        Console.WriteLine("\nShort Details:");
        Console.WriteLine(lectureEvent.DisplayShortDetail());

        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Gathering", "Berry Picking", "Come pick berries at West Chester Lagoon", "2023-09-17", "5:00 PM", "444 Hatcher street", "Rain");


        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.DisplayStandardDetail());


        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.DisplayFullDetail());


        Console.WriteLine("\nShort Details:");
        Console.WriteLine(outdoorEvent.DisplayShortDetail());



        Receptions receptionEvent = new Receptions("Reception", "Meet Ted Stevens", "Meet our Senator Ted Stevens", "2015-10-30", "7:00 PM", "429 Denali street", "mandychadwickppr@alaska.gov");


        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.DisplayStandardDetail());


        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.DisplayFullDetail());


        Console.WriteLine("\nShort Details:");
        Console.WriteLine(receptionEvent.DisplayShortDetail());

    }
}