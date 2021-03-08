using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUi.Models;

namespace WebUi.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult List()
        {
            Employee objEmployee = new Employee();
            var employeeList = objEmployee.GetEmployee();
            return View(employeeList);
        }
    }
}