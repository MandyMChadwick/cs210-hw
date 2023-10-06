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
        Console.WriteLine($"You have completed {_activityName} in {_duration} seconds.");
    }

    public void ShowSpinner(int seconds)
    {
        int spinDuration = seconds * 1000; // Convert seconds to milliseconds
        Console.WriteLine("Spinning...");
        Thread.Sleep(spinDuration);
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
