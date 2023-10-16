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

    public string Pace()
    {
        double pace = _lengthMinutes / getDistance();
        return $"{pace:F2}"; // "{pace:F2}" specifies two decimal places
    }


    public string DisplayStartingMessage()
    {
        DateTime localDate = DateTime.Now;
        return $"Welcome to our exercise Application! {localDate}";
    }

    public abstract float getDistance();
    public abstract string Summary();
}