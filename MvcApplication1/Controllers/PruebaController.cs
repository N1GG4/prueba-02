﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace MvcApplication1.Controllers
{
    public class PruebaController : Controller
    {
        //
        // GET: /Prueba/

        public ActionResult Index()
        {
            return View();
        }

    }
}
