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
        [RegularExpression("^(\\d|\\w|city)+$")]
        public String State {get; set;}

        public string IsValid()
        {
            string retval = String.Empty;
            //Only Employees in the state of California can be added.
            if (this.State != "CA")
            {
                retval += "State must be (CA) California. ";
            }
            //If City is entered, it may not contain any special characters, spaces or the word "city" in it.
            
            return retval;
        }

    }
}
