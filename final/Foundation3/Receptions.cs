public class Receptions : Event
{


    private string _email;

    Receptions(string email, string type, string title, string description, string date, string time, string weather, string address) : base(type, title, description, date, time, address)
    {
        _email = email;
    }
}