using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Antlr.Runtime;
using WebUi.Models;
using DataAccess;
using WebUi.Models.FormModels;

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

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Departments = GetDepartments();
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            ViewBag.Departments = GetDepartments();
            
            var firstName = Convert.ToString(frm["firstName"]);

            if (string.IsNullOrWhiteSpace(firstName))
            {
                TempData["Message"] = "First Name Required";
                return View();
            }
            
            
            var lastName = Convert.ToString(frm["lastName"]);
            var employeeId = Convert.ToString(frm["employeeId"]);
            var ddlDepartment = Convert.ToInt32(frm["ddlDepartment"]);
            var salary = Convert.ToDecimal(frm["salary"]);
            
            var db = new DbOperations();
            db.InsertEmployee(firstName, lastName, employeeId, ddlDepartment, salary);
            
            return RedirectToAction("List");
        }
        
        
        //Another Way
        [HttpGet]
        public ActionResult Create2()
        {
            var departments = GetDepartments();
            ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");
            return View();
        }

        [HttpPost]
        public ActionResult Create2(CreateEmployeeModel model)
        {
            var departments = GetDepartments();
            ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");


            if (!ModelState.IsValid)
            {
                TempData["Message"] = "Input error found";
                return View(model);
            }
            
            var db = new DbOperations();
            db.InsertEmployee(model.FirstName, model.LastName, model.EmployeeId, model.DepartmentId, model.Salary);
            
            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            return View();
        }


        public ActionResult Delete(int id)
        {
            var db = new DbOperations();
            db.DeleteEmployee(id);
            return RedirectToAction("List");
        }


        public List<Department> GetDepartments()
        {
            var db = new DbOperations();
            var data = db.GetAllDepartments();
            var list = new List<Department>();

            foreach (DataRow dr in data.Rows)
            {
                var dep = new Department();

                dep.Id = Convert.ToInt32(dr["Id"]);
                dep.Name = Convert.ToString(dr["Name"]);
                dep.ShortName = Convert.ToString(dr["ShortName"]);
                
                list.Add(dep);
            }

            return list;
        }
        
        
    }
}