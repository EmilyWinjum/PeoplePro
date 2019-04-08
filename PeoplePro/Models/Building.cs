using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Building
    {
        [Display(Name="Building Number")]
        public int BuildingId { get; set; }
        [Display(Name="Building Name")]
        public string BuildingName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
