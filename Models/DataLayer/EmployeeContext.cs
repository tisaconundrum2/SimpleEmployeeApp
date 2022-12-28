using Microsoft.EntityFrameworkCore;
using SimpleEmployeeApp.Models.DataLayer.SeedData;
using SimpleEmployeeApp.Models.DomainModels;

namespace SimpleEmployeeApp.Models.DataLayer
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedEmployee());
        }
    }
}
