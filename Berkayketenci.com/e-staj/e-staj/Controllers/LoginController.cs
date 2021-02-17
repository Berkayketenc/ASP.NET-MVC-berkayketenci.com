using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static e_staj.Models.BKcomEntities;
using System.Web.Security;
using e_staj.Models;
using System.Security.Cryptography.X509Certificates;

namespace e_taj.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        BKcomEntities db = new BKcomEntities();
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(tblAdmin p)
        {
            var bilgiler = db.tblAdmin.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAIL, false);
                Session["Mail"] = bilgiler.MAIL.ToString();
               
                return RedirectToAction("Index", "");
            }
            else
            {
                return View();
            }
                
        }
        public ActionResult OturumuKapat()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("", "");
        }

    }
}