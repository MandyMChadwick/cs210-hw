using System;
using System.Collections.Generic;
using System.Threading;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string activityName, string description, int duration)
        : base(activityName, description, duration)
    {

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",

        };


    }

    public override void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine("Get ready. Press enter to continue.");
        Console.ReadLine();

        int durationInSeconds = base._duration;
        DateTime endTime = DateTime.Now.AddSeconds(durationInSeconds);

        Console.WriteLine("Reflection Activity Started.");

        while (DateTime.Now < endTime)
        {
            DisplayPrompt();
            DisplayQuestions();
            Console.WriteLine("Press enter to continue to the next question.");
            Console.ReadLine();
        }

        base.DisplayEndingMessage(); ;
    }

    private void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        _prompts.Add(randomPrompt);
        Console.WriteLine("Ponder: " + randomPrompt);
    }

    private void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
            Console.WriteLine("Ponder this: " + question);

            ShowSpinner(3); // Pause for 3 seconds
        }


    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

}
