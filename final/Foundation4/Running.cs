public class Running : Activity
{


    public Running(string date, int lengthMinutes, int distance) : base(date, lengthMinutes, distance)
    {



    }
    public override string Summary()
    {
        return $"{getDate()} Running  {getlengthMinutes()} Distance, Speed {getSpeed()}{getDistance()} Pace: {getSpeed()} min per mile";

        //03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    }




}


