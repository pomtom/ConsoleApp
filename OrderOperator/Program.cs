using Database;

namespace OrderOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new TryDbContext();


            Console.WriteLine($"Before order by ascending");
            var employees = context.Employees;

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Name);
            }

            var emps = employees;
            Console.WriteLine($"After Order by Ascending");
            foreach (var employee in emps.OrderBy(a => a.Name))
            {
                Console.WriteLine(employee.Name);
            }

            Console.WriteLine($"After Order by Descending");
            foreach (var employee in emps.OrderByDescending(a => a.Name))
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}