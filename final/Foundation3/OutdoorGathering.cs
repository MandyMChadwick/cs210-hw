using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string type, string title, string description, string date, string time, string address, string weather)
        : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public string WeatherInfo()
    {
        return $"Weather for {_title}: {_weather}";
    }
    public override string DisplayFullDetail()
    {
        return base.DisplayFullDetail() + $"\nWeather: {_weather}";
    }

}
