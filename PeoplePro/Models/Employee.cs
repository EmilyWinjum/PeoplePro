using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Display(Name ="Building")]
        public int? BuildingId { get; set; }
        [Display(Name = "Department")]
        public int? DepartmentId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        public virtual Building Building { get; set; }
        public virtual Department Department { get; set; }
    }


}

