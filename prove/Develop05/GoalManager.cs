using System.Runtime.CompilerServices;

public class GoalManager

{
    public List<Goal> goals;
    private int _score;

    public GoalManager()
    {
        // Initialize the goals list in the constructor.
        goals = new List<Goal>();
    }


    public void CreateGoal()

    {

        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the goal points: ");
        int points;
        if (int.TryParse(Console.ReadLine(), out points))
        {
            Goal newGoal = new SimpleGoal(name, description, points);
            goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Goal creation failed.");
        }
    }


    public void DisplayPlayerInfo()
    {

    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void RecordEvent()
    {
        // Console.Write("Enter the goal name you want to record an event for: ");
        //  string name = Console.ReadLine();
        // Goal goal = goals.Add;


    }
    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved to goals.txt");
    }
    public void LoadGoals()
    {
        if (File.Exists("goals.csv"))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader("goals.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        string name = parts[0];
                        string description = parts[1];
                        int points = int.Parse(parts[2]);
                        bool isComplete = bool.Parse(parts[3]);
                        Goal goal = new SimpleGoal(name, description, points);
                        //   goal.SetCompletion(isComplete);
                        goals.Add(goal);
                    }
                }
            }
            Console.WriteLine("Goals loaded from goals.csv");
        }
        else
        {
            Console.WriteLine("No saved goals found.");
        }
    }

}