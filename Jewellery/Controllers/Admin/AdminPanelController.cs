﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jewellery.Controllers.Admin
{
    public class AdminPanelController : Controller
    {
        // GET: AdminPanel
        public ActionResult Index()
        {
            return View();
        }
    }
}