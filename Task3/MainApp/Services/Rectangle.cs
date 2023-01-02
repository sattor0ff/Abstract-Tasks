public class Rectange : Shape
{
    protected double _width;
    protected double _length;

    public Rectange()
    {

    }
    public Rectange(double width, double length)
    {
        _width = width;
        _length = length;
    }
    public Rectange(double width, double length, string color, bool filled)
    : base (color,filled)
    {
        _width = width;
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public override double GetArea()
    {
        return _width *_length;
    }
    public override double GetPerimeter()
    {
        return 2 * (_width + _length);
    }
    public override string ToString()
    {
        return $"\nRectanlge:{base.ToString()}\nWidth = {_width}\nLength = {_length}";
    }
}