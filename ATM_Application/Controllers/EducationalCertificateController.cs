using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class EducationalCertificateController : BaseController
    {
        // GET: EducationalCertificate
        public ActionResult SchoolCertificate()
        {
            return View();
        }
        public ActionResult UnivversityCertificate()
        {
            return View();
        }
    }
}