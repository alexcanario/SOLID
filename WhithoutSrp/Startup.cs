using Srp.Solid.model;

namespace Solid.src;

public static class Startup
{
    public static IList<Employee> GetEmployees() {
        var employees = new List<Employee>();

        employees.Add(new Employee { Name = "José", Earnings = 900M, Level = SeniorityLevel.Junior, Workload = 220, WorkedHours = 200 });
        employees.Add(new Employee { Name = "Maria", Earnings = 1000, Level = SeniorityLevel.Pleno, Workload = 220, WorkedHours = 200 });
        employees.Add(new Employee { Name = "Manoel", Earnings = 1100M, Level = SeniorityLevel.Senior, Workload = 220, WorkedHours = 200 });

        return employees;
    }
}