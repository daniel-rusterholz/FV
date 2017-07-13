using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FV.Controllers
{
    public class FvController : Controller
    {

        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Sunday)
            //{
            //    return Redirect("/");
            //}
            
            //return Content("Hello");
            return View();
        }

    }
}