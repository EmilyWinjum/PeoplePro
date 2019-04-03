using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int BuildingId { get; set; }
        [Required]
        public string FirstName { get; set; }

        public virtual Building Building { get; set; }
    }


}

