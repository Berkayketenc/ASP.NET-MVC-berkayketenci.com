using e_staj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static e_staj.Models.BKcomEntities;
namespace e_staj.Controllers
{
    public class OgretmenController : Controller
    {
        // GET: Ogretmen
        

        BKcomEntities db = new BKcomEntities();
        [Authorize(Roles ="2")]
        public ActionResult Index()
        {
            var degerler = db.tblStajerler.ToList();
            return View(degerler);
        }
        public ActionResult DosyaGor()
        {

            var degerler = db.tblDosya.ToList();
            return View(degerler);
        }
    }
}
