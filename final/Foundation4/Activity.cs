using System.Reflection.Metadata.Ecma335;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    private int _distance;
    public int Pace()
    {
        return 0;

    }
    public Activity(string date, int lengthMinutes, int distance)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;

        _distance = distance;

    }

    public string getDate()

    {
        DateTime localDate = DateTime.Now;
        string localDateString = localDate.ToString();

        return localDateString;

    }

    public int getlengthMinutes()

    {
        return _lengthMinutes;

    }
    public int getSpeed()
    {
        return _distance / _lengthMinutes;
    }
    public int getDistance()
    {
        return _distance;
    }


    public string DisplayStartingMessage()
    {


        DateTime localDate = DateTime.Now;


        return $"Welcome to our exercize Application! {localDate}";

    }

    public abstract string Summary();



}