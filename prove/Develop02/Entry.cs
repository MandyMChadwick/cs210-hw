using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public string FormatEntry()
    {
        return $"{_date}~~{_promptText}~~{_entryText}";
    }

    public void Display()
    {
        PromptGenerator p = new PromptGenerator();
        _promptText = p.GetRandomPrompt();

        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine("Write your entry:");
        _entryText = Console.ReadLine();
    }
}
