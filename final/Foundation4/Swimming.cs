public class Swimming : Activity
{
    private float _laps;

    public Swimming(string date, int lengthMinutes, float laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override float getDistance()
    {

        return _laps * 50 / 1000;
    }

    public override string Summary()
    {
        return $"{getDate()} Swimming ({getLengthMinutes()} min) - Distance {getDistance()} meters, Speed {Speed()}, Pace: {Pace()} ";
    }
}