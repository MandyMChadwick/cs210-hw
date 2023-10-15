public class Swimming : Activity
{




    public Swimming(string date, int lengthMinutes, int distance) : base(date, lengthMinutes, distance)
    { }
    public override string Summary()
    {


        return $"{getDate()} Swimming {getlengthMinutes()} Distance, Speed {getSpeed()}{getDistance()} Pace: {getSpeed()} min per mile";
    }


}