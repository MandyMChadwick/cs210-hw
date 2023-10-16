using System.Net.Sockets;

public class Event
{
    private string _type;
    private string _title;
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
    { /*Standard details - Lists the title, description, date, time, and address.*/
        return $" Type of Event: {_type} Event Title: {_title} Event Description: {_description} Event Date: {_date} Event Time {_time} Event Address {_address}";
    }
    public string DisplayFullDetail()
    {//Full details - Lists all of the above, plus type of event and information specific to that event type. 
     //For lectures, this includes the speaker name and capacity. For receptions 
     //this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
        return $" Type of Event: {_type} Event Title: {_title} Event Date: {_date}";
    }

    public string DisplayShortDetail()
    //Short description - Lists the type of event, title, and the date.
    {
        return $" Type of Event: {_type} Event Title: {_title} Event Date: {_date}";
    }


    /*Standard details - Lists the title, description, date, time, and address.
Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity. For receptions this includes an email for RSVP. For outdoor gatherings, this includes a statement of the weather.
Short description - Lists the type of event, title, and the date.*/
}



