using Database;

namespace OrderOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Before order by ascending");
            WrpperEmployee Wrapperemp = new WrpperEmployee();

            var employees = Wrapperemp.GetAllEmployees();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine($"After Order by Ascending");
            foreach (var employee in employees.OrderBy(a => a.Name))
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine($"After Order by Descending");
            foreach (var employee in employees.OrderByDescending(a => a.Name))
            {
                Console.WriteLine(employee.Name);
            }

            Console.ReadLine();
        }
    }
}