using mvcFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcFactory.Controllers
{
    public class SupervisorController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ShowSupervisorName()
        {
            ViewBag.SupervisorName = "Biggie";
            return View();
        }
        public ActionResult ShowSupervisor()
        {
            return View();
        }
        public ActionResult ShowAllSupervisorsNames()
        {
            ViewBag.AllSupervisorsNames = new string[] { "supervisor1", "supervisor2", "supervisor3", "supervisor4", "supervisor5", "supervisor6" };
            return View();
        }
        public ActionResult ShowAllSupervisors()
        {
            return View();
        }
        public ActionResult CreateSupervisor()
        {
            Supervisor newSupervisor = new Supervisor("J", "Cole", 1994, 7);
            ViewBag.supervisor = newSupervisor;
            return View();
        }
        public ActionResult CreateSupervisorModel()
        {
            return View(new Supervisor("J", "Cole", 1994, 7));
        }

        public ActionResult CreateSupervisorsList()
        {
            List<Supervisor> supervisors = new List<Supervisor>();
            supervisors.Add(new Supervisor("first", "supervisor", 1973, 1));
            supervisors.Add(new Supervisor("second", "supervisor", 1996, 23));
            supervisors.Add(new Supervisor("third", "supervisor", 1990, 6));
            supervisors.Add(new Supervisor("forth", "supervisor", 1945, 12));
            return View(supervisors);
        }
    }
}