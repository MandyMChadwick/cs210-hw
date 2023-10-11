public class Triangle : Shape

{
    private double _height;
    private double _base;
    public Triangle(string color, double height, double Tbase) : base(color)
    {
        _height = height;
        _base = Tbase;
    }

    public override double GetArea()
    {
        double baseHeight = _base * _height;
        return baseHeight / 2;
    }
}