using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewDayNewLeaf.Controllers
{
    public class FishInfoController : Controller
    {
        //
        // GET: /FishInfo/

        public ActionResult Index(string fishName)
        {
            ViewBag.Title = "New Day, New Leaf";
            ViewBag.FishName = fishName;

            return View();
        }

    }
}
