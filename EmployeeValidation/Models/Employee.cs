using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeValidation.Models
{
    public class Employee
    {
        [Required]
        public int Id {get;set;}

        [Required]
        [StringLength(50)]
        public String Name {get; set;}

        
        [Required]
        [StringLength(100)]
        public String Address {get; set;}

        [Required]
        [StringLength(50)]
        public String City {get; set;}

        [Required]
        [StringLength(50)]
        public String State {get; set;}

    }
}
