

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double length, double width) : base(color)
    {

        _length = length;
        _width = width;
    }


    public override double GetArea()
    {
        return _length * _width;
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
}*/