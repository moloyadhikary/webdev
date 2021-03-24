using System.ComponentModel.DataAnnotations;

namespace WebUi.Models.FormModels
{
    public class CreateEmployeeModel
    {
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