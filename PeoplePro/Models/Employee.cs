using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeoplePro.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        public virtual ICollection<Department> Departments { get; set; }

        public virtual ICollection<Building> Buildings { get; set; }
    }


}

