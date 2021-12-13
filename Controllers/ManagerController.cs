using mvcFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcFactory.Controllers
{
    public class ManagerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowManagerName()
        {
            ViewBag.ManagerName = "Nas";
            return View();
        }
        public ActionResult ShowManager()
        {
            return View();
        }
        public ActionResult ShowAllManagersNames()
        {
            ViewBag.AllManagersNames = new string[] { "manager1", "manager2", "manager3", "manager4", "manager5", "manager6" };
            return View();
        }
        public ActionResult ShowAllManagers()
        {
            return View();
        }
        public ActionResult CreateManager()
        {
            Manager newManager = new Manager("Jay", "Z", "Sales");
            ViewBag.manager = newManager;
            return View();
        }
        public ActionResult CreateManagerModel()
        {
            return View(new Manager("Jay", "Z", "Sales"));
        }

        public ActionResult CreateManagersList()
        {
            List<Manager> managers = new List<Manager>();
            managers.Add(new Manager("first", "supervisor", "Finance"));
            managers.Add(new Manager("second", "supervisor", "Delivery"));
            return View(managers);
        }
    }
}