using e_staj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using static e_staj.Models.BKcomEntities;

namespace e_staj.Controllers
{

    public class StajyerController : Controller
    {
        // GET: Stajyer
        BKcomEntities db = new BKcomEntities();
        [Authorize(Roles = "3")]
        public ActionResult Index()
        {

            var degerler = db.tblStajerler.ToList();
            return View(degerler);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblStajerler p8)
        {

            db.tblStajerler.Add(p8);
            db.SaveChanges();
            return View();
        }
        
        }
    }
