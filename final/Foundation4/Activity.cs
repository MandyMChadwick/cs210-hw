using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;
    public int Speed()
    {
        return 0;
    }
    public int Distance()
    {
        return 0;
    }
    public int Pace()
    {
        return 0;
    }

    public int Summary(int distance, int speed, int pace)
    {
        return 0;
    }




}