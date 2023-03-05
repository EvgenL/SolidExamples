
/// <summary>
/// D — Dependency Inversion (Принцип инверсии зависимостей)
/// Абстракции не должны зависеть от деталей. Детали должны зависеть от абстракций.
/// </summary>
public static class DependencyInversion
{
    public static void Test()
    {
        var hero = new HeroModified(new DamageCalculatorMultiply());  
        hero.Attack = 50;  
        hero.Level = 150;  
        Console.WriteLine($"The Total Damage is {hero.GetDamage()}");  
        
        
        var hero2 = new HeroModified(new DamageCalculatorPercent());  
        hero2.Attack = 50;  
        hero2.Level = 150;  
        Console.WriteLine($"The Total Damage is {hero2.GetDamage()}");  

    }
}


// Not following the Dependency Inversion Principle  
   
public class DamageCalculator  
{  
    public float CalculateDamage(int attack, int level) => attack * level;  
}  
  
public class HeroDetails  
{  
    public int Attack { get; set; }  
    public int Level { get; set; }  
    
    public float GetDamage()  
    {  
        var calculator = new DamageCalculator();  
        return calculator.CalculateDamage(Attack, Level);  
    }  
} 








// Following the Dependency Inversion Principle  
  
public interface IDamageCalculator  
{  
    float CalculateDamage(int attack, float level);  
}  




  
public class DamageCalculatorMultiply : IDamageCalculator  
{  
    public float CalculateDamage(int attack, float level) => attack * level;  
}  

public class DamageCalculatorPercent : IDamageCalculator  
{  
    public float CalculateDamage(int attack, float level) => attack * (1 + level / 100);  
}  




  
public class HeroModified  
{  
    private readonly IDamageCalculator _damageCalculator;  
    public int Attack { get; set; }  
    public int Level { get; set; }  
    
    public HeroModified(IDamageCalculator damageCalculator)  
    {  
        _damageCalculator = damageCalculator;  
    }  
    
    public float GetDamage()  
    {  
        return _damageCalculator.CalculateDamage(Attack, Level);  
    }  
}  