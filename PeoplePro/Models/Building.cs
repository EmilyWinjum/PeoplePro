using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeoplePro.Models
{
    public class Building
    {
        public int Id { get; set; }
        public string BuildingName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
