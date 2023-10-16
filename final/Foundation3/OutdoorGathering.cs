public class OutdoorGathering : Event
{
    private string _weather;
    OutdoorGathering(string type, string title, string description, string date, string time, string weather, string address) : base(type, title, description, date, time, address)
    {
        string _weather = weather;
    }




}
