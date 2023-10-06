using System;
using System.Threading;

class Activity
{
    private string _activityName;
    private string _description;
    public int _duration;

    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName} activity.");
        Console.WriteLine(_description);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_activityName}. Thank you.");//in {_duration} seconds
    }

    public void ShowSpinner(int seconds)
    {
        var _animationStrings = new List<string>
           {
               "|",
               "/",
               "-",
               "\\"
           };
        int animationIndex = 0;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("\r" + _animationStrings[animationIndex]);
            animationIndex = (animationIndex + 1) % _animationStrings.Count;
            Thread.Sleep(250); // Sleep for 250 milliseconds
        }

        Console.Write("\r");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Time remaining: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }
    }

    public virtual void Run()
    {
        DisplayStartingMessage();

        DisplayEndingMessage();
    }
}
