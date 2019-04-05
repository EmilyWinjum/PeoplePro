using PeoplePro.Models;
using Microsoft.EntityFrameworkCore;

namespace PeoplePro.Data
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Department> Departments { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Building>().ToTable("Building");
            modelBuilder.Entity<Department>().ToTable("Department");
        }
    }
}
