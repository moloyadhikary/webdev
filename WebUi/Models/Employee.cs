using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebUi.Models
{
    public class Employee
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public DateTime JoiningDate { get; set; }
        public decimal BasicSalary { get; set; }
        public bool IsCurrent { get; set; }
        public string DepartmentName { get; set; }
    }
}