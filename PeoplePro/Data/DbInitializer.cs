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
                new Building{BuildingName="Mechanical labs"},
                new Building{BuildingName="IT helpdesk"},
                new Building{BuildingName="Student teaching area"},
                new Building{BuildingName="Concert hall"},
                new Building{BuildingName="Rehearsal space"},
                new Building{BuildingName="Writing room"}
            };

            foreach (Building b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();

            var employees = new Employee[]
            {
                new Employee{FirstName="Emily",BuildingId=2, DepartmentId=1},
                new Employee{FirstName="Josie",BuildingId=2, DepartmentId=1},
                new Employee{FirstName="Chris",BuildingId=5, DepartmentId=3},
                new Employee{FirstName="Phi",BuildingId=1, DepartmentId=4},
                new Employee{FirstName="Zi",BuildingId=6, DepartmentId=4}
            };

            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

        }
    }
}
