using System;

public class Lectures : Event
{
    private string _speakerName;
    private int _capacity;

    public Lectures(string type, string title, string description, string date, string time, string address, string speakerName, int capacity)
        : base(type, title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string LectureList()
    {
        return $"Lecture: {_title} by {_speakerName}, Capacity: {_capacity}";
    }
    public override string DisplayFullDetail()
    {
        return base.DisplayFullDetail() + $"\nSpeaker Name: {_speakerName}, Capacity: {_capacity}";
    }

}
