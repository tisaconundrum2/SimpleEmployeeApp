using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleEmployeeApp.Models.DomainModels;

namespace SimpleEmployeeApp.Models.DataLayer.SeedData
{
    internal class SeedEmployee : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee { Id = 1, firstName = "Peter", middleInitial = "E.", lastName = "Rowan", address = "3322 Davis Street", city = "Carnesville", state = "GA", zip = "30521", dateOfBirth = DateTime.Parse("09-27-1985"), socialSecurityNumber = "671-24-6875" },
                new Employee { Id = 2, firstName = "Randall", middleInitial = "W.", lastName = "Hatfield", address = "169 Breezewood Court", city = "Coolidge", state = "KS", zip = "67836", dateOfBirth = DateTime.Parse("02-28-1957"), socialSecurityNumber = "513-12-4682" },
                new Employee { Id = 3, firstName = "Casey", middleInitial = "A.", lastName = "Foster", address = "3455 Dancing Dove Lane", state = "New York", city = "NY", zip = "10011", dateOfBirth = DateTime.Parse("08-13-1991"), socialSecurityNumber = "069-34-5134" }
                );
        }
    }
}
