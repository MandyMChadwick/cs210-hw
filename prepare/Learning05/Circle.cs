public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }



    public override double GetArea()
    {
        return Math.PI * _radius * _radius;

    }

}
/*public class Square : Shape

{
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
*/