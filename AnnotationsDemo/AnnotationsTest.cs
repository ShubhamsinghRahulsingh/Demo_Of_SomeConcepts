using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationsDemo
{
    public class AnnotationsTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee Class Validation");
            Console.WriteLine("---------------------------------\n");
            Employee objEmployee = new Employee();
            objEmployee.Name = "Shubham";
            objEmployee.Age = 26;
            objEmployee.PhoneNumber = "7830456363";
            objEmployee.Email = "Shubh@gmail.com";

            //inbuilt class for validation to pass object,service and dictionary
            //if services and dictionaries are not used we can make it as null.
            ValidationContext context = new ValidationContext(objEmployee, null, null);//creating instance of validationcontext class constructor
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);//validating input values

            //conditions if the fields are not available
            if (!valid)
            {
                //foreach loop is used to transverse the data if error occurs prints the error message in different  colours
                foreach (ValidationResult Totalresult in results)
                {
                    Console.WriteLine("Member Name: {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.Write("Error Message:: {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name: " + objEmployee.Name + "\n" + "Age: " + objEmployee.Age + "\n" + "PhoneNumber: " + objEmployee.PhoneNumber + "\n" + "Email: " + objEmployee.Email);
            }
            //to print the console in our wish colour
            Console.WriteLine("Press Any Key to Exit");
            Console.ReadKey();
        }
    }
}
