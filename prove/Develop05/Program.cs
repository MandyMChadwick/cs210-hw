
using System;
using System.IO;
using System.Globalization;
class Program
{
    static void Main(string[] args)

    {
        GoalManagement goals = new GoalManagement();

        Console.Clear();
        Console.WriteLine("Eternal Quest Goals For Now and Beyond");
        Console.WriteLine($"Point Total {goals.GetTotalPoints()}");
        MainMenu mainMenu = new MainMenu();
        GoalMenu goalMenu = new GoalMenu();

        int selection = 0;
        while (selection != 6)

        {
            selection = mainMenu.UserChoice();
            switch (selection)

            {
                case 1:
                    Console.Clear();
                    int goalInput = 0;
                    while (goalInput != 5)
                    {
                        goalInput = goalMenu.GoalChoice();
                        switch (goalInput)
                        {
                            case 1://SimpleGoal
                                Console.WriteLine("Give your goal a name");
                                string name = Console.ReadLine();
                                Console.WriteLine("Describe your goal");
                                string description = Console.ReadLine();
                                Console.WriteLine("List the points for this goal");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2://Eternal Goal
                                Console.WriteLine("Give your goal a name");
                                name = Console.ReadLine();
                                Console.WriteLine("Describe your goal");
                                description = Console.ReadLine();
                                Console.WriteLine("List the points for this goal");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:// Checklist Goal
                                Console.WriteLine("Give your goal a name");
                                name = Console.ReadLine();
                                Console.WriteLine("Describe your goal");
                                description = Console.ReadLine();
                                Console.WriteLine("List the points for this goal");
                                points = int.Parse(Console.ReadLine());
                                Console.WriteLine("You will get a bonus if you complete it how many times?");
                                int bonusTimes = int.Parse(Console.ReadLine());
                                Console.WriteLine("How many bonus points will you earn from this goals?");
                                int xtraPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal checkGoal = new ChecklistGoal("Check List Goal:", name, description, points, bonusTimes, xtraPoints);
                                goals.AddGoal(checkGoal);
                                goalInput = 5;
                                break;
                            case 4:// Other Goal
                                Console.WriteLine("Give your goal a name");
                                name = Console.ReadLine();
                                Console.WriteLine("Describe your goal");
                                description = Console.ReadLine();
                                Console.WriteLine("List the points for this goal");
                                points = int.Parse(Console.ReadLine());
                                OtherGoal otherGoal = new OtherGoal("Check List Goal:", name, description, points);
                                goals.AddGoal(otherGoal);
                                goalInput = 5;
                                break;
                            default:
                                Console.WriteLine("Enter a valid option");
                                break;
                        }
                    }
                    break;
                case 2:
                    Console.Clear();
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.ListGoals();
                    break;
                case 3:

                    goals.SaveGoals();
                    break;
                case 4:

                    Console.Clear();
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.LoadGoals();
                    break;
                case 5:

                    Console.Clear();
                    Console.Write($"You have {goals.GetTotalPoints()} points");
                    goals.RecordGoalEvent();
                    break;
                case 6:

                    Console.WriteLine("Thank You and Good Bye!");
                    break;
                default:
                    Console.WriteLine($"Enter a Valid Option");
                    break;
            }
        }
    }
}