public class Circle
{
    public double _radius;
    public const double PI = 3.14;

    public Circle()
    {

    }
    public Circle(double radius)
    {
        _radius = radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
    public void GetArea()
    {
        System.Console.WriteLine(_radius * _radius * PI);
    }
    public double GetCircumference()
    {
        return 2*PI*_radius;
    }
    public override string ToString()
    {
        return $"Cirle: {_radius}";
    }
}