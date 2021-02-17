using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_staj.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            ViewBag.Title = "BK | Sertifikalarım";
            return View();
        }
    }
}