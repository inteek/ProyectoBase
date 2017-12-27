using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inteek.Controllers
{
    public class NotificacionesController : Controller
    {

        public ActionResult EnviarNotificacion()
        {
            return PartialView("EnviarNotificacion");
        }


        public ActionResult EnviarSolicitud()
        {
            return PartialView("EnviarSolicitud");
        }



    }
}
