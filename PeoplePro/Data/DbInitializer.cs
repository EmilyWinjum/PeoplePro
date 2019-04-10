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
            if (context.Employees.Any() || context.Buildings.Any() || context.Departments.Any())
            {
                return; // DB is seeded
            }
            

            var departments = new Department[]
            {
                new Department{Name="Engineering"},
                new Department{Name="Education"},
                new Department{Name="Music"},
                new Department{Name="Writing"}
            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();

            var buildings = new Building[]
            {
                new Building{Name="Mechanical labs"},
                new Building{Name="IT helpdesk"},
                new Building{Name="Student teaching area"},
                new Building{Name="Concert hall"},
                new Building{Name="Rehearsal space"},
                new Building{Name="Writing room"}
            };

            foreach (Building b in buildings)
            {
                context.Buildings.Add(b);
            }
            context.SaveChanges();

            var employees = new Employee[]
            {
                new Employee{FirstName="Emily",BuildingId=buildings[1].BuildingId, DepartmentId=departments[0].DepartmentId},
                new Employee{FirstName="Josie",BuildingId=buildings[1].BuildingId, DepartmentId=departments[0].DepartmentId},
                new Employee{FirstName="Miranda",BuildingId=buildings[4].BuildingId, DepartmentId=departments[1].DepartmentId},
                new Employee{FirstName="Phi",BuildingId=buildings[0].BuildingId, DepartmentId=departments[3].DepartmentId},
                new Employee{FirstName="Zi",BuildingId=buildings[5].BuildingId, DepartmentId=departments[3].DepartmentId}
            };

            foreach (Employee e in employees)
            {
                context.Employees.Add(e);
            }
            context.SaveChanges();

        }
    }
}
