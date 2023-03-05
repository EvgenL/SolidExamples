namespace SolidExamples;

public class Example1
{
    public static void Test()
    {
        var transformer = new Transformer();
        transformer.Fly();
        transformer.Walk();
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