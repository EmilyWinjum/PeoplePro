using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Department
    {
        [Display(Name="Department Number")]
        public int DepartmentId { get; set; }
        [Display(Name="Department Name")]
        public string DepartmentName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
