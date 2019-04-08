using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int BuildingId { get; set; }
        public int DepartmentId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public virtual Building Building { get; set; }
        public virtual Department Department { get; set; }
    }


}

