public class Square : Rectange
{
    public double _side = 1.0;

    public Square()
    {

    }
    public Square(double side)
    {
        _side = side;
    }
    public Square(double side, string color, bool filled)
    {
        _side = side;
        _color = color;
        _filled = filled;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
    public void SetWidth(double side)
    {
        _width = side;
    }
    public void SetLength(double side)
    {
        _length = side;
    }
    public override string ToString()
    {
        return $"\nSquare:\nColor = {_color}\nFilled = {_filled}\nWidth = {_width}\nLength = {_length}";
    }
}