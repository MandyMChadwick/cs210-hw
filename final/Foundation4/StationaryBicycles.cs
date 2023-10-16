public class StationaryBicycles : Activity
{
    private int _distance;

    public StationaryBicycles(string date, int lengthMinutes, int distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override float getDistance()
    {

        return _distance;
    }

    public override string Summary()
    {
        return $"{getDate()} Stationary Bike ({getLengthMinutes()} min) - Distance {getDistance()} miles, Speed {Speed} mph, Pace: {Pace} min/mile";
    }
}
