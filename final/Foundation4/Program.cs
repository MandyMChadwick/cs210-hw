using System;

class Program
{
    static void Main(string[] args)
    {
        Running running1 = new Running("10/10/2023", 60, 10);
        StationaryBicycles stationarybike1 = new StationaryBicycles("10/12/2023", 60, 20);
        Swimming swimming1 = new Swimming("07/22/19", 60, 100);
        Console.WriteLine($"{running1.Summary()}");
        Console.WriteLine($"{stationarybike1.Summary()}");
        Console.WriteLine($"{swimming1.Summary()}");

    }
}