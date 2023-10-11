using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Your choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("You chose create a new goal");
                GoalManager manager = new GoalManager();
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                Console.WriteLine("You chose to list your goals");
                //StartReflectingActivity();
            }
            else if (choice == "3")
            {
                Console.WriteLine("You chose to save your goals");
                //StartListingActivity();
                GoalManager manager = new GoalManager();
                manager.SaveGoals();
            }

            else if (choice == "4")
            {
                Console.WriteLine("You chose to load your goals");
                GoalManager manager = new GoalManager();
                manager.LoadGoals();
            }

            else if (choice == "5")
            {
                Console.WriteLine("You chose to record an event");
                //StartListingActivity();
            }




        } while (choice != "6");
        Console.WriteLine("Goodbye!");

    }
}