using System;

namespace Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tryContext = new TryDbContext();

            //AnyEmployeeExistWithFirstOrDefault(empcontext);
            //AnyEmployeeExistWithAny(empcontext);
            //AnyEmployeeExistWithContains(empcontext);

            if (AnyEmployeeExistWithFirstOrDefault(tryContext))
                AddEmployees(tryContext);

            var employees = tryContext.Employees.ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Name}");
            }

            Console.ReadLine();
        }

        private static bool AnyEmployeeExistWithFirstOrDefault(TryDbContext empcontext)
        {
            var emp = empcontext.Employees.FirstOrDefault();
            return emp is null ? true : false;
        }

        private static bool AnyEmployeeExistWithAny(TryDbContext empcontext)
        {
            return empcontext.Employees.Any(a => a.City == "Sangola");
        }

        private static bool AnyEmployeeExistWithContains(TryDbContext empcontext)
        {
            List<string> citis = new List<string> { "Sangola", "Pune" };
            var emp = empcontext.Employees.Where(a => citis.Contains(a.City));
            return emp.Any();
        }

        private static void AddEmployees(TryDbContext context)
        {
            var employees = new List<Employee>();
            employees.Add(new Employee() { Name = "Sarang", City = "Khed", Phone = "123", Gender = "Male" });
            employees.Add(new Employee() { Name = "Mannya", City = "Solapur", Phone = "456", Gender = "Male" });
            employees.Add(new Employee() { Name = "jatin", City = "Pune", Phone = "789", Gender = "Male" });
            employees.Add(new Employee() { Name = "Gandhar", City = "Ranchi", Phone = "012", Gender = "Male" });
            employees.Add(new Employee() { Name = "Kasyap", City = "Sangola", Phone = "345", Gender = "Male" });
            employees.Add(new Employee() { Name = "Ganga", City = "Kashmir", Phone = "678", Gender = "FeMale" });
            employees.Add(new Employee() { Name = "Raju", City = "Sangola", Phone = "987", Gender = "Male" });
            employees.Add(new Employee() { Name = "Niti", City = "Delhi", Phone = "874", Gender = "FeMale" });


            foreach (var emp in employees)
            {
                context.Add(emp);
            }

            context.SaveChanges();
        }
    }
}