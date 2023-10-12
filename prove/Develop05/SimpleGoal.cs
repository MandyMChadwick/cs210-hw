using System;

public class SimpleGoal : Goal
{

    private string _type = "Simple Goal:";
    private bool _status;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public SimpleGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }
    public Boolean Finished()
    {
        return _status;
    }

    public override void ListGoal(int i)
    {
        if (Finished() == false)
        {
            Console.WriteLine($"{i}. Simple Goal: [ ] {GetName()} ({GetDescription()})");
        }
        else if (Finished() == true)
        {
            Console.WriteLine($"{i}. [X] Simple Goal:  {GetName()} ({GetDescription()})");
        }
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
        _status = true;
        Console.WriteLine($"You are doing great! you have {GetPoints()} points");
    }

}



