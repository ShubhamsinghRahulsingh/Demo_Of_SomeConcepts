using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class Employee
    {
        //Gets or sets the name
        [Required(ErrorMessage = "Employee {0} is required")]//Attribute
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name Should be of minimum 3 characters and a maximum of 100 characters")]
        [DataType(DataType.Text)]//Attribute which accept datatype of text only
        public string Name { get; set; }
        //Gets or sets the age
        [Range(18, 99, ErrorMessage = "Age should be above 18")]//Attribute to set range
        public int Age { get; set; }
        //Gets or sets the phoneNumber
        [DataType(DataType.PhoneNumber)]//Attribute
        [Phone]//Attribute in namespace that defines particular format for phone number
        public string PhoneNumber { get; set; }
        //gets or sets the email
        [DataType(DataType.EmailAddress)]//Attribute
        [EmailAddress]
        public string Email { get; set; }
    }
}
