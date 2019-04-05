using System;
using System.Collections.Generic;
using System.Linq;
using PeoplePro.Models;
using System.Threading.Tasks;

namespace PeoplePro.Data
{
    public class DbInitializer
    {
        public static void Initialize(PeopleContext context)
        {
            context.Database.EnsureCreated();

            // Look for existing entries
            if (context.Employees.Any())
            {
                return; // DB is seeded
            }
            

            var departments = new Department[]
            {
                new Department{DepartmentName="Engineering"},
                new Department{DepartmentName="Education"},
                new Department{DepartmentName="Music"},
                new Department{DepartmentName="Writing"}
            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var buildings = new Building[]
            {
                new Building{BuildingName="Mechanical labs",DepartmentId=1},
                new Building{BuildingName="IT helpdesk",DepartmentId=1},
                new Building{BuildingName="Student teaching area",DepartmentId=2},
                new Building{BuildingName="Concert hall",DepartmentId=3},
                new Building{BuildingName="Rehearsal space",DepartmentId=3},
                new Building{BuildingName="Writing room",DepartmentId=4}
            };

            foreach (Building b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();

            var employees = new Employee[]
            {
                new Employee{FirstName="Emily",BuildingId=2},
                new Employee{FirstName="Josie",BuildingId=2},
                new Employee{FirstName="Chris",BuildingId=5},
                new Employee{FirstName="Phi",BuildingId=1},
                new Employee{FirstName="Zi",BuildingId=6}
            };

            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

        }
    }
}
