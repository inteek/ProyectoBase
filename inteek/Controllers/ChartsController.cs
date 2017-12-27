using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inteek.Controllers
{
    public class ChartsController : Controller
    {
        //
        // GET: /Charts/

        public ActionResult C3()
        {
            return PartialView("C3");
        }


        public ActionResult Sparklines()
        {
            return PartialView("Sparklines");
        }





    }
}
