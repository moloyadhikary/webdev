using System;
using System.Collections.Generic;
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

        public List<Employee> GetEmployee()
        {
            var list = new List<Employee>();

           //list.Add(new Employee{Id = 1, EmployeeId = "ABC123", FullName = "Moloy"});
            //list.Add(new Employee{Id = 2, EmployeeId = "ABC321", FullName = "Shabab"});

            return list;
        }
    }
}