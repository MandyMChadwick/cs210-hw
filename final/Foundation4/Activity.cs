using System;

public abstract class Activity
{
    private string _date;
    private int _lengthMinutes;

    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string getDate()
    {
        return _date;
    }

    public int getLengthMinutes()
    {
        return _lengthMinutes;
    }

    public double Speed()
    {

        {

            return getDistance() / (_lengthMinutes / 60.0);
        }
    }

    public double Pace()
    {

        {

            return (_lengthMinutes / getDistance());
        }
    }

    public string DisplayStartingMessage()
    {
        DateTime localDate = DateTime.Now;
        return $"Welcome to our exercise Application! {localDate}";
    }

    public abstract float getDistance();
    public abstract string Summary();
}