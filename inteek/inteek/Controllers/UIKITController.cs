using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inteek.Controllers
{
    public class UIKITController : Controller
    {
        //
        // GET: /UIKIT/
          
        public ActionResult Buttons()
        {
            return PartialView("Buttons");
        }

        public ActionResult Typography()
        {
            return PartialView("Typography");
        }

        public ActionResult Grids()
        {
            return PartialView("Grids");
        }

        public ActionResult Panels()
        {
            return PartialView("Panels");
        }

        public ActionResult Notifications()
        {
            return PartialView("Notifications");
        }

        public ActionResult TabsAccordion()
        {
            return PartialView("TabsAccordion");
        }

        public ActionResult ProgressBars()
        {
            return PartialView("ProgressBars");
        }

        public ActionResult Extras()
        {
            return PartialView("Extras");
        }


    }
}
