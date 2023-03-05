namespace SolidExamples;

public class Example2
{
    public static void Test()
    {
        var transformer = new Transformer();
        transformer.Fly();
        transformer.Walk();
    }
}



public class Transformer : IFlyingRobot, IWalkingRobot
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