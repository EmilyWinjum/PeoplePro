using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Building
    {
        public int BuildingId { get; set; }
        [Required]
        [Display(Name="Building Name")]
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
