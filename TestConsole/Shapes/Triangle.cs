namespace TestConsole.Shape;

public class Triangle : Shape
{
    public Triangle(double size)
    {
        Width = size;
        Height = size;
    }
    // public double Width { get; set; }

    public override double Area()
    {
        return (Math.PI * (Width * Width));
    }
}