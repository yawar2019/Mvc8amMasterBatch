using Mvc8amMasterBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc8amMasterBatch.Controllers
{
    public class NewController : Controller
    {
        //Deilip have taken Latest
        // GET: New
        public int getId()
        {
            return 1211;
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

        public ActionResult GetEmployee() {

            EmployeeModel obj = new EmployeeModel();
            obj.EmpId = 1;
            obj.EmpName = "Manoj";
            obj.EmpSalary = 70000;
       
            return View(obj);
        }

        public ActionResult GetListEmployee()
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

    }
}