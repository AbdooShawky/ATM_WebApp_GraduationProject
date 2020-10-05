using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class MinistriesController : BaseController
    {
        // GET: Ministries
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Indexs()
        {
            return View();
        }

    }
}