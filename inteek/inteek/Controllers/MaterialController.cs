﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace inteek.Controllers
{
    public class MaterialController : Controller
    {
        //
        // GET: /Material/

        public ActionResult Index()
        {
            return PartialView("Index");
        }

    }
}
