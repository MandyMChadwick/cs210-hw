using System;

class Program
{

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
                Console.WriteLine("You chose the breathing activity");
                StartBreathingActivity();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You chose the reflecting activity");
                StartReflectingActivity();
            }
            else if (choice == "3")
            {
                Console.WriteLine("You chose the listing activity");
                StartListingActivity();
            }
        } while (choice != "4");
        Console.WriteLine("Goodbye!");
    }

    static void StartBreathingActivity()
    {
        string activityName = "Breathing Activity";
        string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        int durationInSeconds = 5;

        BreathingActivity breathingActivity = new BreathingActivity(activityName, description, durationInSeconds);
        breathingActivity.Run();
    }

    static void StartReflectingActivity()
    {
        string activityName = "Reflection Activity";
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        int durationInSeconds = 5;

        ReflectingActivity reflectingActivity = new ReflectingActivity(activityName, description, durationInSeconds);
        reflectingActivity.Run();
    }

    static void StartListingActivity()
    {
        string activityName = "Listing Activity";
        string description = "This activity will involve listing items or thoughts during a specified duration.";
        int durationInSeconds = 20;

        ListingActivity listingActivity = new ListingActivity(activityName, description, durationInSeconds);
        listingActivity.Run();
    }
}
