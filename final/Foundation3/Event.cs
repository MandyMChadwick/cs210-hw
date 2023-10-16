using System;

public class Event
{
    private string _type;
    protected string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string type, string title, string description, string date, string time, string address)
    {
        _type = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayStandardDetail()
    {
        return $"Type of Event: {_type} Event Title: {_title} Event Description: {_description} Event Date: {_date} Event Time: {_time} Event Address: {_address}";
    }

    public virtual string DisplayFullDetail()
    {
        return $"Type of Event: {_type} Event Title: {_title} Event Date: {_date}";
    }

    public string DisplayShortDetail()
    {
        return $"Type of Event: {_type} Event Title: {_title} Event Date: {_date}";
    }
}
