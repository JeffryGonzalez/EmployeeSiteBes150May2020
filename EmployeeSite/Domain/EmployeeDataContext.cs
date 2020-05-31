using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace EmployeeSite.Domain
{
    public class EmployeeDataContext : DbContext
    {
        public EmployeeDataContext(DbContextOptions<EmployeeDataContext> options) : base(options)
        {
           
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "June Smith", Email = "june@aol.com" },
                new Employee { Id = 2, Name = "Bob Jones", Email = "bob@aol.com" }
            );
        }
    }

    public class Employee
    {
        public int Id { get;  set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
