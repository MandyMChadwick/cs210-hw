using System.Drawing;
using System.Security.Cryptography.X509Certificates;

public abstract class Shape
{
    string _color;

    public Shape(string color)
    {
        _color = color;
    }



    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // public virtual double GetArea(double area)

    // {
    //     return 0;

    // }

    public abstract double GetArea();


}



