using System.ComponentModel;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    SimpleGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }


    public override bool IsComplete()
    {

        return false;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}




