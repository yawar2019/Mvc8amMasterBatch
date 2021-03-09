using AdoNetExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetExample.Controllers
{
    public class EmmployeeDetailsController : Controller
    {
        // GET: EmmployeeDetails
        EmployeeContext db = new EmployeeContext();
        public ActionResult Index()
        {
            return View(db.GetEmployees());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection frm)
        {
            string Name = frm["EmpName"];
            int Salary = Convert.ToInt32(frm["EmpSalary"]);
            int i = db.CreateEmployee(Name, Salary);
            if(i>0)
            {
                return RedirectToAction("index");
            }
            else
            {
                return View();
            }
        }
    }
}