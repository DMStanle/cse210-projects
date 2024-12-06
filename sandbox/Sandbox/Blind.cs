public class Blind
{
    private double _width;
    private double _height;
    private string _color;


    public Blind(double width, double height, string color)
    {
        _width = width;
        _height = height;
        _color = color;


    }

    public double GetArea()
    {
        return _width * _height;
    }
}