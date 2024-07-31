namespace WithSrp.Model;

public class Employee
{
    public string Name { get; set; } = string.Empty;
    public decimal Earnings { get; set; }
    public decimal Balance { get; set; }
    public int Workload { get; set; }
    public int WorkedHours { get; set; }
    public SeniorityLevel Level { get; set; }
}