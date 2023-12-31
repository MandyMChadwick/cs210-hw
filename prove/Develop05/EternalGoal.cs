using System;

public class EternalGoal : Goal
{
    // Attributes
    private string _type = "Eternal Goal:";
    private bool _status;


    // Constructors
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }

    // Methods

    public override void ListGoal(int i)
    {
        Console.WriteLine($"{i}. [ ] Eternal Goal: {GetName()} ({GetDescription()})");
    }
    public override string SaveGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_type}; {GetName()}; {GetDescription()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goal> goals)
    {
        Console.WriteLine($"Your doing great! you have {GetPoints()} points");
    }


}