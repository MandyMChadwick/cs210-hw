using System;
using System.Threading;

class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {
    }

    public override void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine("Get ready. Press enter to start the breathing exercise.");
        Console.ReadLine();

        Console.WriteLine("Breathing Activity Started.");

        int durationInSeconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(6);
            Console.WriteLine("Pause");
            ShowCountDown(4);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);

        }

        base.DisplayEndingMessage();
    }
}
