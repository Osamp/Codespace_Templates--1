namespace TestConsole.Shape;

public abstract class Shape
{
   protected double Width { get; set; }

    protected double Height { get; set; }

   public virtual double Area()
    {
        return Width * Height;
    }
}