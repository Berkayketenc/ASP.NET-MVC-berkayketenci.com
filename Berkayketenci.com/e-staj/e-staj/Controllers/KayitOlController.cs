using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static e_staj.Models.BKcomEntities;
using System.Web.Security;
using e_staj.Models;

namespace e_staj.Controllers
{
    public class KayitOlController : Controller
    {
        // GET: KayitOl
        BKcomEntities db = new BKcomEntities();
        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(tblAdmin p)
        {
            if (!ModelState.IsValid)
            {
                return View("Kayit");
            }
            db.tblAdmin.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}