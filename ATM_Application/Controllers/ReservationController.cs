using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace ATM_Application.Controllers
{
    public class ReservationController : BaseController
    {
      
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Indexuser()
        {
            return View();
        }


     


        public ActionResult Create()
        {

            ViewBag.zero = "0";
            return View();
        }

        
        

    }
}