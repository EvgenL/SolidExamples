namespace SolidExamples;

/// <summary>
/// L – Liskov Substitution (Принцип подстановки Барбары Лисков)
/// Наследники могут выполнять роль родителей.
/// </summary>
public static class LiskovSubstitution
{
    public static void Test()
    {
        var tiger = new Tiger();
        AddToZoo(tiger);
        var lion = new Lion();
        AddToZoo(lion);
    }

    
    private static void AddToZoo(IAnimal animal)
    {
        Console.WriteLine("Animal was added! " + animal.MakeSound());
    }
}

public interface IAnimal
{
    public string MakeSound();
}

public class Tiger : IAnimal
{
    public string MakeSound()
    {
        return "Tiger says RRRRR";
    }
}
public class Lion : IAnimal
{
    public string MakeSound()
    {
        return "Lion sleeps tonight";
    }
}







