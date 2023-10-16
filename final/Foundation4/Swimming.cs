public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override int getDistance()
    {
        // Custom logic to calculate distance based on laps
        return _laps * 50 / 1000;
    }

    public override string Summary()
    {
        return $"{getDate()} Swimming ({getLengthMinutes()} min) - Distance {getDistance()} meters, Speed {Speed} m/s, Pace: {Pace:F2} min/100m";
    }
}