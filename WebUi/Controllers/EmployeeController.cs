﻿using System;
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
            try
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
            }
            catch (Exception e)
            {
                TempData["Message"] = e.Message;
            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var db = new DbOperations();
            var data = db.GetEmployeeDetailsById(id);
            var employee = new Employee();

            if (data.Rows.Count > 0)
            {
                employee.BasicSalary = Convert.ToDecimal(data.Rows[0]["BasicSalary"]); 
                employee.DepartmentId = Convert.ToInt32(data.Rows[0]["DepartmentId"]);
                employee.DepartmentName = Convert.ToString(data.Rows[0]["DepartmentName"]);
                employee.EmployeeId = Convert.ToString(data.Rows[0]["EmployeeId"]);
                employee.FirstName = Convert.ToString(data.Rows[0]["FirstName"]);
                employee.Id = Convert.ToInt32(data.Rows[0]["Id"]);
                employee.IsCurrent = Convert.ToBoolean(data.Rows[0]["IsCurrent"]);
                employee.JoiningDate = Convert.ToDateTime(data.Rows[0]["JoiningDate"]);
                employee.LastName = Convert.ToString(data.Rows[0]["LastName"]);
                
                return View(employee);
            }
            else
            {
                TempData["Message"] = "No employee found";
                return RedirectToAction(nameof(List));
            }
           
        }


        public ActionResult Delete(int id)
        {
            var db = new DbOperations();
            db.DeleteEmployee(id);
            return RedirectToAction("List");
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new DbOperations();
            var data = db.GetEmployeeDetailsById(id);
            var employee = new EditEmployeeModel();
            if (data.Rows.Count > 0)
            {
                employee.Salary = Convert.ToDecimal(data.Rows[0]["BasicSalary"]);
                employee.DepartmentId = Convert.ToInt32(data.Rows[0]["DepartmentId"]);
                employee.EmployeeId = Convert.ToString(data.Rows[0]["EmployeeId"]);
                employee.FirstName = Convert.ToString(data.Rows[0]["FirstName"]);
                employee.Id = Convert.ToInt32(data.Rows[0]["Id"]);
                employee.LastName = Convert.ToString(data.Rows[0]["LastName"]);

                var departments = GetDepartments();
                ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");
                return View(employee);
            }
            else
            {
                TempData["Message"] = "No employee found";
                return RedirectToAction(nameof(List));
            }
        }


        [HttpPost]
        public ActionResult Edit(EditEmployeeModel model)
        {
            try
            {
                var departments = GetDepartments();
                ViewBag.DepartmentList = new SelectList(departments, "Id", "Name");
                if (!ModelState.IsValid)
                {
                    TempData["Message"] = "Input error found";
                    return View(model);
                }
                var db = new DbOperations();
                db.UpdateEmployee(model.Id, model.FirstName, model.LastName, model.Salary, model.DepartmentId, model.EmployeeId);
            }
            catch (Exception e)
            {
                TempData["Message"] = e.Message;
            }
            return RedirectToAction("List");
        }


        [HttpGet]
        public ActionResult ChangeStatus(int id, int status)
        {
            var db = new DbOperations();
            db.UpdateEmployeeStatus(id, status);
            return RedirectToAction(nameof(List));
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