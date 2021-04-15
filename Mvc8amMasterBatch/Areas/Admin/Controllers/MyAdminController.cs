using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc8amMasterBatch.Areas.Admin.Controllers
{
    public class MyAdminController : Controller
    {
        // GET: Admin/MyAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}