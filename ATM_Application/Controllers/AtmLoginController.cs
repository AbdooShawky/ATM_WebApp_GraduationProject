using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class ci
    {
        public int citizen_id { get; set; }
        public string citizen_national_id { get; set; }
        public string citizen_first_name { get; set; }
        public string citizen_second_name { get; set; }
        public string citizen_third_name { get; set; }
        public string citizen_fourth_name { get; set; }
        public string citizen_gender { get; set; }




        public string citizen_first_name_arabic { get; set; }
        public string citizen_second_name_arabic { get; set; }
        public string citizen_third_name_arabic { get; set; }
        public string citizen_fourth_name_arabic { get; set; }

    }
    public class AtmLoginController : BaseController
    {
        // GET: AtmLogin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Lang()
        {

            return View();
        }
        [HttpPost]
        public void GetData(ci dd)
        {
            // citizen data inside atm 
            Session["CitizenId"] = dd.citizen_id;
            Session["CnameArabic"] = dd.citizen_first_name_arabic + " " +dd.citizen_second_name_arabic + " " +dd.citizen_third_name_arabic + " " +dd.citizen_fourth_name_arabic;
            Session["NationalId"] = dd.citizen_national_id;
            Session["gender"] = dd.citizen_gender;
            if (Session["lang"] != null)
            {
                if (Session["lang"].ToString().Equals("ar-EG"))
                {
                    Session["Cname"] = dd.citizen_first_name_arabic + " " + dd.citizen_second_name_arabic + " " + dd.citizen_third_name_arabic + " " + dd.citizen_fourth_name_arabic;


                }
                else
                {
                    Session["Cname"] = dd.citizen_first_name + " " + dd.citizen_second_name + " " + dd.citizen_third_name + " " + dd.citizen_fourth_name;

                }
            }
            else
            {
                Session["Cname"] = dd.citizen_first_name + " " + dd.citizen_second_name + " " + dd.citizen_third_name + " " + dd.citizen_fourth_name;

            }
            Session["succmsg"] = ATM_Application.Languages.lang.UserWelcom + " " + Session["Cname"];

        }
        // ----------------- Ajax Call ---------------------
        public JsonResult GetMessage()
        {
            string msg = "";
            if (Session["succmsg"] != null)
            {
                
                msg = Session["succmsg"].ToString();
                Session["succmsg"] = null;
            }
            return Json(msg, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCitizenId()
        {
            if(Session["CitizenId"]!= null)
                return Json((int)Session["CitizenId"], JsonRequestBehavior.AllowGet);
            // int Id = (int)Session["citizenID"];
            return Json("", JsonRequestBehavior.AllowGet);

        }
        public JsonResult GetCitizenGender()
        {
            if (Session["gender"] != null)
                return Json(Session["gender"].ToString(), JsonRequestBehavior.AllowGet);
            // int Id = (int)Session["citizenID"];
            return Json("", JsonRequestBehavior.AllowGet);

        }

        public JsonResult Sessionvalue()
        {
            string aa = "";
            if (Session["lang"] != null)
                aa = Session["lang"].ToString();
            return Json(aa, JsonRequestBehavior.AllowGet);
        }
    }
}