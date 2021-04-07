using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUi.Models.FormModels
{
    public class EditEmployeeModel
    {
        [Required]
        public int Id { get; set; }


        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Employee Id")]
        [Required]
        public string EmployeeId { get; set; }

        [Display(Name = "Department")]
        [Required]
        public int DepartmentId { get; set; }

        [Display(Name = "Salary")]
        [Required]
        public decimal Salary { get; set; }
    }
}