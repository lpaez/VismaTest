using Microsoft.EntityFrameworkCore;
using VismaTest.Infrastructure.Data.EntityConfigurations;
using VismaTest.Models;

namespace VismaTest.Infrastructure.Factory
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EmployeeConfiguration());
        }
    }
}
