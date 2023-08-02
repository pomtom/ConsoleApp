using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Database
{
    public class TryDbContext : DbContext
    {
        private readonly ILoggerFactory _loggerFactory = LoggerFactory.Create(config => config.AddConsole());

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(_loggerFactory);
            optionsBuilder.UseSqlServer(@"Data Source=BTL389;Initial Catalog=TryDB;Persist Security Info=True;TrustServerCertificate=True;Trusted_Connection=true;MultipleActiveResultSets=true;");
        }
    }
}
