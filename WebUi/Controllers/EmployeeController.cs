using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebUi.Models;
using DataAccess;

namespace WebUi.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult List()
        {
            var db = new DbOperations();
            var data = db.GetAllEmployee();
            var list = new List<Employee>();

            foreach (DataRow dr in data.Rows)
            {
                var e = new Employee();

                e.BasicSalary = Convert.ToDecimal(dr["BasicSalary"]);
                e.DepartmentId = Convert.ToInt32(dr["DepartmentId"]);
                e.DepartmentName = Convert.ToString(dr["DepartmentName"]);
                e.EmployeeId = Convert.ToString(dr["EmployeeId"]);
                e.FirstName = Convert.ToString(dr["FirstName"]);
                e.Id = Convert.ToInt32(dr["Id"]);
                e.IsCurrent = Convert.ToBoolean(dr["IsCurrent"]);
                e.JoiningDate = Convert.ToDateTime(dr["JoiningDate"]);
                e.LastName = Convert.ToString(dr["LastName"]);
                
                list.Add(e);
            }
            
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }
    }
}