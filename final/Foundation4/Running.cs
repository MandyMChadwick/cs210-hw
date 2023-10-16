public class Running : Activity
{
    private int _distance;
    public Running(string date, int lengthMinutes, int distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override float getDistance()
    {

        return _distance;
    }
    public override string Summary()
    {
        return $"{getDate()} Running ({getLengthMinutes()} min) - Distance {getDistance()} miles, Speed {Speed} mph, Pace: {Pace} min/mile";
    }
}


