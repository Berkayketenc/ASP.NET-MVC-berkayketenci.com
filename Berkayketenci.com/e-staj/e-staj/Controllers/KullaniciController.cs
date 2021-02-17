using e_staj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static e_staj.Models.BKcomEntities;

namespace e_staj.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        BKcomEntities db = new BKcomEntities();
        [Authorize(Roles = "1")]
        public ActionResult Index()
        {
            var degerler = db.tblAdmin.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult KullaniciEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KullaniciEkle(tblAdmin p)
        {
            db.tblAdmin.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult SIL(int ID)
        {
            var kullanici = db.tblAdmin.Find(ID);
            db.tblAdmin.Remove(kullanici);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult KullaniciGetir(int ID)
        {
            var kullanicigtr = db.tblAdmin.Find(ID);
            return View("KullaniciGetir", kullanicigtr);
        }
        public ActionResult Guncelle(tblAdmin p1)
        {
            var kullanicilar = db.tblAdmin.Find(p1.ID);
            
            kullanicilar.AD = p1.AD;
            kullanicilar.SOYAD = p1.SOYAD;
            kullanicilar.MAIL = p1.MAIL;
            kullanicilar.SIFRE = p1.SIFRE;
            kullanicilar.ROLES = p1.ROLES;
            db.SaveChanges();
            return RedirectToAction("Index");
        }





    }
}