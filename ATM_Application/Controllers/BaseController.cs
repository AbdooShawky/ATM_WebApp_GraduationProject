using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;

namespace ATM_Application.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(Session["lang"] != null)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(Session["lang"].ToString());
            if(Session["lang1"] != null)
            {
              Thread.CurrentThread.CurrentUICulture = new CultureInfo(Session["lang1"].ToString());
            }
            //string aa = Request.UrlReferrer.ToString();
            //if(aa != "")
            //Session["url"] = aa;
        }
    }
}