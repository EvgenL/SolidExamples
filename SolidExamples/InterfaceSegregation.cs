namespace SolidExamples;

/// <summary>
/// I — Interface Segregation (Принцип разделения интерфейсов)
/// Интерфейсы должны быть маленькими, одноцелевыми. Не должно быть неиспользуемых "притянутых" методов.
/// Интерфейс: Это контракт о том, какие методы должны быть в классе
/// </summary>
public static class InterfaceSegregation
{
    public static void Test()
    {
        var transformer = new Transformer();
        transformer.Fly();
        transformer.Walk();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        var coolTransformer = new CoolTransformer();
        coolTransformer.Fly();
        coolTransformer.Walk();
    }
}







public class Transformer : IRobot
{
    public void Fly()
    {
        Console.WriteLine("Transformer: I Fly!");
    }

    public void Walk()
    {
        Console.WriteLine("Transformer: I Walk!");
    }
}

public interface IRobot
{
    void Fly();
    void Walk();
}

















public class WalkingTransformer : IRobot
{
    public void Fly()
    {
        // это нам не нужно
    }

    public void Walk()
    {
        Console.WriteLine("WalkingTransformer: I walk");
    }
}





















public class CoolTransformer : IFlyingRobot, IWalkingRobot
{
    public void Fly()
    {
        Console.WriteLine("Transformer: I Fly!");
    }

    public void Walk()
    {
        Console.WriteLine("Transformer: I Walk!");
    }
}

public interface IFlyingRobot
{
    void Fly();
}

public interface IWalkingRobot
{
    void Walk();
}







