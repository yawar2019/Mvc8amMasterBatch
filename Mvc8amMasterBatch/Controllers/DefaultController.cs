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
        public ActionResult GoodMorning()
        {
            return View();
        }
    }
}