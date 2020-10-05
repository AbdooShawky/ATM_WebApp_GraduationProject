using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class DoctorReservationController : BaseController
    {
        // GET: DoctorReservation
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult IndexV()
        {
            return View();
        }
        public ActionResult Delete(int DId)
        {
            Session["delete"] = DId;
            return View();

        }

        public JsonResult GetD()
        {
            int gg = 0;
            if (Session["delete"] != null)
                gg = (int)Session["delete"];
            return Json(gg , JsonRequestBehavior.AllowGet);
        }
    }
}