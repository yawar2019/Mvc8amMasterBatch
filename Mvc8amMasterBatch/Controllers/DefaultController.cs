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
        public RedirectResult GoodMorning()
        {
            return Redirect("http://www.google.com");
        }

        public RedirectResult GoodMorning2()
        {
            return Redirect("~/new/GetListEmployee?id=100");
        }

        public RedirectToRouteResult GoodEvening() {

            return RedirectToRoute("burger");
        }
    }
}