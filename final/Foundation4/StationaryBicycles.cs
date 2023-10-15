public class StationaryBicycles : Activity
{


    public StationaryBicycles(string date, int lengthMinutes, int distance) : base(date, lengthMinutes, distance)

    {

    }
    public override string Summary()
    {
        return $"{getDate()} Stationary Bike  {getlengthMinutes()} Distance, Speed {getSpeed()}{getDistance()} Pace: {getSpeed()} min per mile";
    }
}