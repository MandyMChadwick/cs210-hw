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
}
