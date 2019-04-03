using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PeoplePro.Models;

namespace PeoplePro.DAL
{
    public class PeopleContext : DbContext
    {
        public PeopleContext() : base("PeopleContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
