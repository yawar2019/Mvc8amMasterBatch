using Mvc8amMasterBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc8amMasterBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult GoodMorning(int ? id)
        {
             ViewData["info"] = "james";
            //ViewBag.info = "Khalnayak";
            return View();
        }

        public RedirectResult GoodMorning2()
        {
            //string s = ViewData["info"].ToString();//null
            string s = ViewBag.info;
            return Redirect("~/new/GetListEmployee?id=100");
        }

        public RedirectResult GoodMorning3(EmployeeModel emp)
        {
            return Redirect("~/new/GetListEmployee?id=100");
        }

        public RedirectToRouteResult GoodEvening() {

            return RedirectToRoute("burger");
        }

        public RedirectToRouteResult GoodEvening2()
        {
             
            return RedirectToAction("GoodMorning","Default",new {id=1211 });
        }
        public RedirectToRouteResult GoodEvening3()
        {
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpId = 1211;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 21000;

            return RedirectToAction("GoodMorning3", "Default", obj);
        }

        public ActionResult GetMovie()
        {
            Movies mobj = new Movies();
            mobj.MovieId = 1;
            mobj.MovieName ="Motapatlu";


            Movies mobj1 = new Movies();
            mobj1.MovieId = 2;
            mobj1.MovieName = "SuperCock";

            Movies mobj2 = new Movies();
            mobj2.MovieId = 3;
            mobj2.MovieName = "Bahuballi";

            List<Movies> listMovie = new List<Movies>();
            listMovie.Add(mobj);
            listMovie.Add(mobj1);
            listMovie.Add(mobj2);


            return View(listMovie);
        }

        public PartialViewResult GetMovie1()
        {
            Movies mobj = new Movies();
            mobj.MovieId = 1;
            mobj.MovieName = "Motapatlu";


            Movies mobj1 = new Movies();
            mobj1.MovieId = 2;
            mobj1.MovieName = "SuperCock";

            Movies mobj2 = new Movies();
            mobj2.MovieId = 3;
            mobj2.MovieName = "Bahuballi";

            List<Movies> listMovie = new List<Movies>();
            listMovie.Add(mobj);
            listMovie.Add(mobj1);
            listMovie.Add(mobj2);


            return PartialView("_MypartialView1", listMovie);
        }

        public JsonResult GetmeJsonData()
        {

            Movies mobj = new Movies();
            mobj.MovieId = 1;
            mobj.MovieName = "Motapatlu";


            Movies mobj1 = new Movies();
            mobj1.MovieId = 2;
            mobj1.MovieName = "SuperCock";

            Movies mobj2 = new Movies();
            mobj2.MovieId = 3;
            mobj2.MovieName = "Bahuballi";

            List<Movies> listMovie = new List<Movies>();
            listMovie.Add(mobj);
            listMovie.Add(mobj1);
            listMovie.Add(mobj2);

            return Json(listMovie);


        }

        public FileResult GetmeFile() {

            return File("~/Web.config","text");
        }

        public FileResult GetmeFile2()
        {

            return File("~/File/ActionResult.pdf", "application/pdf", "ActionResult.pdf");
        }
        public ActionResult HtmlHelperExample()
        {
            EmployeeEntities db = new Models.EmployeeEntities();
            ViewBag.Country = new SelectList(db.Roles, "id", "RoleName",3);
            EmployeeModel obj = new Models.EmployeeModel();
            obj.EmpName = "Swamy";
            return View(obj);
        }

        public ActionResult TestTempData()
        {
            TempData["frnd"] = "DevAnand";
          return  RedirectToAction("TestTempData2");
        }
        public ActionResult TestTempData2()
        {
            //ViewBag.frnd = TempData["frnd"];
            //TempData.Keep();
            ViewBag.frnd = TempData.Peek("frnd");


            return View();
        }
    }
}