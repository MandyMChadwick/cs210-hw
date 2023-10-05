using System.Net;

class ReflectingActivity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. ");

        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string sessionSeconds = Console.ReadLine();
    }
    public void Run()
    {
        Console.WriteLine("Get ready Consider the following prompt:");
        Console.WriteLine("---Think of a time when you did something really difficult. ---");
        Console.WriteLine("When you ave something in mind press enter to continue.");
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
    }

    public string GetRandomPrompt()
    {

        return "string";
    }

    public string GetRandomQuestion()
    {
        return "string";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {


    }



}