using Mvc8amMasterBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc8amMasterBatch.Filter;
using System.Web.Security;

namespace Mvc8amMasterBatch.Controllers
{     
    public class NewController : Controller
    {
        //Mounika have taken Latest
        // GET: New
   [MyFilter]
        public ActionResult FavoriteTeam()
        {

            ViewBag.Team = "Favorite Team of Suja is Kenya Team";
            return View();
        }

        [Route("Anna/Wada")]
        [Route("Anna/Idly")]
        [Route("Anna/Dosa")]
        public ViewResult AboutUs()
        {
            return View();

        }

        public string getData(int? id)
        {

            return "My Employee Id:" + id;
        }

        public string getData2(int? id, string Name)
        {

            return "My Employee Id:" + id + " Name is:" + Name;
        }

        public string getData3(int? id, string Name, string Designation)
        {

            return "My Employee Id:" + id + " Name is:" + Name + " Designation" + Designation;
        }

        public string getData4(int? id)
        {

            return "My Employee Id:" + id + " Name is:" + Request.QueryString["Name"] + " Designation" + Request.QueryString["Designation"];
        }
        public ViewResult sendData()
        {
            return View("AboutUs");
        }
        public ViewResult callOtherCntView()
        {
            return View("~/Views/Default/GoodMorning.cshtml");
        }

        public ActionResult sendinfo()
        {
            ViewBag.FName = "Kalpana";
            ViewBag.FName1 = "Dilip";

            return View();
        }


        public ActionResult sendInfoUsingModel()
        {
            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 70000;

            ViewBag.Employee = obj;


            return View();
        }

        public ActionResult sendmulInfoUsingModel()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 70000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Suja";
            obj1.EmpSalary = 170000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Dilip";
            obj2.EmpSalary = 270000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);

            ViewBag.Employee = listObj;



            return View();
        }

        public ActionResult GetEmployee()
        {

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 70000;

            return View(obj);
        }

        public ViewResult GetListEmployee()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 70000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Suja";
            obj1.EmpSalary = 170000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Dilip";
            obj2.EmpSalary = 270000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            return View(listObj);
        }


        public ActionResult GetListEmpDept()
        {

            List<EmployeeModel> listObj = new List<EmployeeModel>();

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 70000;

            EmployeeModel obj1 = new EmployeeModel();
            obj1.EmpId = 2;
            obj1.EmpName = "Suja";
            obj1.EmpSalary = 170000;

            EmployeeModel obj2 = new EmployeeModel();
            obj2.EmpId = 3;
            obj2.EmpName = "Dilip";
            obj2.EmpSalary = 270000;

            listObj.Add(obj);
            listObj.Add(obj1);
            listObj.Add(obj2);


            /////////////////////////////////////



            List<DepartmentModel> listdeptObj = new List<DepartmentModel>();


            DepartmentModel detp = new DepartmentModel();
            detp.DeptId = 1;
            detp.DeptName = "IT";

            DepartmentModel detp1 = new DepartmentModel();
            detp1.DeptId = 2;
            detp1.DeptName = "Network";

            listdeptObj.Add(detp);
            listdeptObj.Add(detp1);


            EmpDept empdeptobj = new Models.EmpDept();
            empdeptobj.listemp = listObj;
            empdeptobj.listdept = listdeptObj;


            return View(empdeptobj);
        }

        public ActionResult GetListEmpDept2()
        {
            return View();
        }

        public ActionResult getPartialView()
        {
          return  View();
        }

        [HttpGet]
        public ActionResult ValidationExample()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ValidationExample(RegisterModel reg)
        {
            if (ModelState.IsValid)
            {
                //logic
                return Redirect("~/new/ValidationExample");
            }
            else
            {
                // block when ur model is not valid 
                return View(reg);
            }
           
        }

        public ActionResult Login() {
            return View();
        }
        [HttpPost]
        public ActionResult Login(RegisterModel reg)
        {
            if (reg.UserName == "Admin" && reg.Password == "Admin")
            {
                FormsAuthentication.SetAuthCookie(reg.UserName, false);
                return Redirect("~/New/DashBoard");
            }
            else
            {
                return View();
            }
        }
        [Authorize]
        public ActionResult DashBoard()
        {
            return View();
        }

        
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/New/Login");
        }
    }
}