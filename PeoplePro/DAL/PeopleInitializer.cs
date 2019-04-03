using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using PeoplePro.Models;
using System.Threading.Tasks;

namespace PeoplePro.DAL
{
    public class PeopleInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PeopleContext>
    {
        protected override void Seed(PeopleContext context)
        {
            var departments = new List<Department>
            {
                new Department{DepartmentName="Engineering"},
                new Department{DepartmentName="Education"},
                new Department{DepartmentName="Music"},
                new Department{DepartmentName="Writing"}
            };

            departments.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var buildings = new List<Building>
            {
                new Building{BuildingName="Mechanical labs",DepartmentId=1},
                new Building{BuildingName="IT helpdesk",DepartmentId=1},
                new Building{BuildingName="Student teaching area",DepartmentId=2},
                new Building{BuildingName="Concert hall",DepartmentId=3},
                new Building{BuildingName="Rehearsal space",DepartmentId=3},
                new Building{BuildingName="Writing room",DepartmentId=4}
            };

            buildings.ForEach(s => context.Buildings.Add(s));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{FirstName="Emily",BuildingId=2},
                new Employee{FirstName="Josie",BuildingId=2},
                new Employee{FirstName="Chris",BuildingId=5},
                new Employee{FirstName="Phi",BuildingId=1},
                new Employee{FirstName="Zi",BuildingId=6}
            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();

        }
    }
}
