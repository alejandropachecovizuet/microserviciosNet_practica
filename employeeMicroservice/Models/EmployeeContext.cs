using Microsoft.EntityFrameworkCore;

namespace employeeMicroservice.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> EmployeeItems { get; set; }
    }
}