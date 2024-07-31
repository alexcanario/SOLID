using WithSrp.Model;

namespace WithSrp;

public static class Balance
{
    public static decimal Calc(Employee employee) => employee.WorkedHours * (employee.Earnings / employee.Workload);
}