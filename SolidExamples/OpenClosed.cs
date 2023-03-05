
/// <summary>
/// O – Open-Closed (Принцип открытости-закрытости)
/// Классы должны быть открыты для расширения, но закрыты для модификации.
/// </summary>

public static class OpenClosed
{
    public static void Test()
    {
        var calc1 = new SalaryCalculatorStage1(1000);
        int monthlySalary = calc1.CalculateTotalSalary();
        Console.WriteLine("Salary: " + monthlySalary);
        
        
        
        
        
        
        var calc2 = new SalaryCalculatorStage2(1000, 3000, 990);
        int junSalary = calc2.CalculateTotalSalary("Junior");
        int seniorSalary = calc2.CalculateTotalSalary("Senior");
        Console.WriteLine("Junior salary: " + junSalary);
        Console.WriteLine("Senior salary: " + seniorSalary);
        
        
        
        
        
        
        var junCalc = new JuniorSalaryCalculator(1000);
        Console.WriteLine("Junior salary: " + junCalc.CalculateTotalSalary());
        var senCalc = new SeniorSalaryCalculator(3000, 990);
        Console.WriteLine("Senior salary: " + senCalc.CalculateTotalSalary());
    }
}










public class SalaryCalculatorStage1
{
    private const int HoursPerMonth = 22 * 8;
    private readonly int _developerHourlyRate;
    
    public SalaryCalculatorStage1(int developerHourlyRate)
    {
        _developerHourlyRate = developerHourlyRate;
    }
    
    public int CalculateTotalSalary()
    {
        return _developerHourlyRate * HoursPerMonth;
    }
}














public class SalaryCalculatorStage2
{
    private const int HoursPerMonth = 22 * 8;
    private readonly int _juniorHourlyRate;
    private readonly int _seniorHourlyRate;
    private readonly int _seniorBonus;

    public SalaryCalculatorStage2(int juniorHourlyRate, int seniorHourlyRate, int seniorBonus)
    {
        _juniorHourlyRate = juniorHourlyRate;
        _seniorHourlyRate = seniorHourlyRate;
        _seniorBonus = seniorBonus;
    }
    
    public int CalculateTotalSalary(string grade)
    {
        if (grade == "Junior")
        {
            return _juniorHourlyRate * HoursPerMonth;
        }
        else if (grade == "Senior")
        {
            return _seniorHourlyRate * HoursPerMonth + _seniorBonus;
        }

        return 0;
    }
}










public abstract class SalaryCalculator
{
    protected const int HoursPerMonth = 22 * 8;

    public abstract int CalculateTotalSalary();
}




public class JuniorSalaryCalculator : SalaryCalculator
{
    private readonly int _hourlyRate;

    public JuniorSalaryCalculator(int hourlyRate)
    {
        _hourlyRate = hourlyRate;
    }

    public override int CalculateTotalSalary()
    {
        return _hourlyRate * HoursPerMonth;
    }
}




public class SeniorSalaryCalculator : SalaryCalculator
{
    private readonly int _hourlyRate;
    private readonly int _seniorBonus;

    public SeniorSalaryCalculator(int hourlyRate, int seniorBonus)
    {
        _hourlyRate = hourlyRate;
        _seniorBonus = seniorBonus;
    }

    public override int CalculateTotalSalary()
    {
        return _hourlyRate * HoursPerMonth + _seniorBonus;
    }
}