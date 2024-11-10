using CRUD_Depatment_and_Employee.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Depatment_and_Employee.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
      : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
