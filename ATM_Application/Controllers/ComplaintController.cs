using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class ComplaintController : Controller
    {
        // GET: Complaint
        public ActionResult Create()
        {
            return View();
        }
    }
}