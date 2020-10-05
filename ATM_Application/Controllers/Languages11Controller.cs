using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class Languages11Controller : Controller
    {
        // GET: Base
        public ActionResult Arabic()
        {
          //  Session["flagIcon"] = "egypt-flag-round-icon-32.png";
            Session["lang"] = "ar-EG";
            return RedirectToAction("Login", "AtmLogin");
        }


        public ActionResult English()
        {
           // Session["flagIcon"] = "united-states-of-america-flag-round-icon-32.png";
            Session["lang"] = "en-US";
            return RedirectToAction("Login", "AtmLogin");
        }
    }
}