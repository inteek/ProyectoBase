using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inteek.Controllers
{
    public class PagesController : Controller
    {
        //
        // GET: /Pages/

        public ActionResult SignIn()
        {
            return PartialView("SignIn");
        }

        public ActionResult SignUp()
        {
            return PartialView("SignUp");
        }

        public ActionResult ForgetPass()
        {
            return PartialView("ForgetPass");
        }

        public ActionResult LockScreen()
        {
            return PartialView("LockScreen");
        }

        public ActionResult PageNotFound()
        {
            return PartialView("PageNotFound");
        }



        public ActionResult Timeline()
        {
            return PartialView("Timeline");
        }

        public ActionResult Search()
        {
            return PartialView("Search");
        }

        public ActionResult Invoice()
        {
            return PartialView("Invoice");
        }

    }
}
