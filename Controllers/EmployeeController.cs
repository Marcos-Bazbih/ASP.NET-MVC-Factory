using mvcFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcFactory.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowEmployeeName()
        {
            ViewBag.EmployeeName = "Tupac";
            return View();
        }
        public ActionResult ShowEmployee()
        {
            return View();
        }
        public ActionResult ShowAllEmployeesNames()
        {
            ViewBag.AllEmployeesNames = new string[] {"employee1", "employee2", "employee3", "employee4", "employee5", "employee6"};
            return View();
        }
        public ActionResult ShowAllEmployees()
        {
            return View();
        }
        public ActionResult CreateEmployee()
        {
            Employee newEmployee = new Employee("kendrick","lamar",1987,"050-8173256");
            ViewBag.employee = newEmployee;
            return View();
        }
        public ActionResult CreateEmployeeModel()
        {
            return View(new Employee("kendrick", "lamar", 1987, "050-8173256"));
        }


        public ActionResult CreateEmployeesList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("first", "employee", 1985, "052-253-4855"));
            employees.Add(new Employee("second", "employee", 1955, "055-793-4855"));
            employees.Add(new Employee("third", "employee", 1988, "052-153-3855"));
            employees.Add(new Employee("forth", "employee", 1990, "054-800-1855"));
            employees.Add(new Employee("fifth", "employee", 1998, "055-169-4805"));
            employees.Add(new Employee("sixth", "employee", 2002, "050-774-7851"));
            return View(employees);
        }
    }
}