using System;
using System.Threading;
using System.Collections.Generic;

class ListingActivity : Activity
{
    private List<string> _questions;

    public ListingActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {

        _questions = new List<string>
        {
            "What are you thankful for today?",
            "Name someone you appreciate and why.",
            "What positive experiences have you had recently?",
            "What makes you feel happy?",
            "What are your hopes for the future?",
            "What inspires you?",
        };
    }

    public override void Run()
    {
        base.Run();

        Console.WriteLine("Get ready. Press enter to start the Blessing Activity.");
        Console.ReadLine();

        Console.WriteLine("Blessing Activity Started. You have 30 seconds to write your blessings.");


        DisplayRandomQuestion();

        int durationInSeconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        while (DateTime.Now < endTime)
        {

            Console.WriteLine("Write down a blessing: ");
            string blessing = Console.ReadLine();
            Console.WriteLine($"You wrote: {blessing}");

            Thread.Sleep(1000);
        }

        Console.WriteLine("Blessing Activity Completed.");
    }

    private void DisplayRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        string randomQuestion = _questions[index];
        Console.WriteLine("Random Question: " + randomQuestion);
    }
}