using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using static e_staj.Models.BKcomEntities;
using e_staj.Models;


namespace e_staj.Controllers
{
    public class DosyaEkleeController : Controller
    {
        // GET: DosyaEklee
        BKcomEntities db = new BKcomEntities();
        
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/App_Data/yuklenenbelgeler"));
            string[] fileNames = new string[files.Count()];
            for (int i = 0; i < files.Count(); i++)
            {
                fileNames[i] = files[i].Substring(files[i].IndexOf("yuklenenbelgeler"));
            }
            TempData["files"] = fileNames;
            return View();
        }

        [HttpPost]
        public ActionResult Index(IEnumerable<HttpPostedFileBase> files, string desc)
        {

            foreach (var file in files)
            {
                if (file != null && file.ContentLength > 0)
                {
                    var fileName = desc + "_" + Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/yuklenenbelgeler"), fileName);
                    file.SaveAs(path);
                }
            }
            return RedirectToAction("Index");
        }
       
    }

}