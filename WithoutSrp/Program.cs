using WithOutSrp;
using WithOutSrp.Model;

Console.Clear();
var employees = Database.GetEmployees();

foreach(var emp in employees) {
    emp.Balance = CalcBalance(emp);
    Console.WriteLine("-------------------------------------------------------");
    Console.WriteLine($"{emp.Name}: Earnings: {emp.Earnings:C2}: - Balance: {emp.Balance:C2}");
    Console.WriteLine("-------------------------------------------------------");
    Pay(emp);
    Console.WriteLine($"Updating annual leave for {emp.Name}");
    UpdateEmployeeWorkedHours(emp);
    
}


static decimal CalcBalance(Employee employee) => employee.WorkedHours * (employee.Earnings / employee.Workload);
static void Pay(Employee emp) => Console.WriteLine($"{emp.Name} Funds transferred, done! {emp.Balance:C2}");
static void UpdateEmployeeWorkedHours(Employee emp) => Console.WriteLine($"{emp.Name} worked {emp.WorkedHours} out of {emp.Workload} hours this month\n\n");