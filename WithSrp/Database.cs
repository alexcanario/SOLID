using WithSrp.Model;

namespace WithSrp;

public static class Database
{
    public static IList<Employee> GetEmployees() {
        var employees = new List<Employee>
        {
            new() { Name = "José", Earnings = 900M, Level = SeniorityLevel.Junior, Workload = 220, WorkedHours = 200 },
            new() { Name = "Maria", Earnings = 1000, Level = SeniorityLevel.Pleno, Workload = 220, WorkedHours = 200 },
            new() { Name = "Manoel", Earnings = 1100M, Level = SeniorityLevel.Senior, Workload = 220, WorkedHours = 200 }
        };

        return employees;
    }

    public static void SetEmployeeWorkedHours(Employee emp) => Console.WriteLine($"{emp.Name} worked {emp.WorkedHours} out of {emp.Workload} hours this month\n\n");
}