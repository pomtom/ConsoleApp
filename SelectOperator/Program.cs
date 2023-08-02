using Database;

namespace SelectOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new TryDbContext();

            var employees = context.Employees.SetQueryName()
                .Where(a => a.City == "Sangola")
                .Select(emp => new
                {
                    NameWithID = $"{emp.Id} - {emp.Name}",
                    City = emp.City
                });

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.NameWithID} : {emp.City}");
            }

            Console.ReadLine();
        }
    }
}