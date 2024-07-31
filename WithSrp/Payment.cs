using WithSrp.Model;

namespace WithSrp;

public static class Payment
{
    public static void Start(){
        var employees = Database.GetEmployees();
        foreach(var emp in employees) {
            emp.Balance = Balance.Calc(emp);

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"{emp.Name}: Earnings: {emp.Earnings:C2}: - Balance: {emp.Balance:C2}");
            Console.WriteLine("-------------------------------------------------------");

            Pay(emp);
            Database.SetEmployeeWorkedHours(emp);
        }
    }

    static void Pay(Employee emp) => Console.WriteLine($"{emp.Name} Funds transferred, done! {emp.Balance:C2}");
}