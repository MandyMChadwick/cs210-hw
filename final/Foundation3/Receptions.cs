using System;

public class Receptions : Event
{
    private string _email;

    public Receptions(string type, string title, string description, string date, string time, string address, string email)
        : base(type, title, description, date, time, address)
    {
        _email = email;
    }

    public string RSVPInfo()
    {
        return $"RSVP for {_title}: Send an email to {_email}";
    }

    public override string DisplayFullDetail()
    {
        return base.DisplayFullDetail() + $"\n RSVP at: {_email}";
    }
}
