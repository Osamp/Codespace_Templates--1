namespace TestConsole.Classes;

public class TestGenerics<T>
{
    public T X;
    
    public TestGenerics(T param)
    {
        X = param;
    }
    
    public string? GetString()
    {
        return X?.ToString();
    }
}