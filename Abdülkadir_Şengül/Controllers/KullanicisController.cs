using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Abdülkadir_Şengül.Models;

namespace Abdülkadir_Şengül.Controllers
{
    public class KullanicisController : Controller
    {
        private MakaleEntities db = new MakaleEntities();

        [_KullaniciControl]
        public ActionResult Index()
        {
            var kullanici = db.Kullanici.Include(k => k.Bolum).Include(k => k.Unvan);
            return View(kullanici.ToList());
        }


        [_KullaniciControl]
        [Route("KullaniciEkle")]
        public ActionResult KullaniciEkle()
        {
            ViewBag.BolumNo = new SelectList(db.Bolum, "No", "Ad");
            ViewBag.UnvanNo = new SelectList(db.Unvan, "No", "Ad");
            return View();
        }

        [HttpPost]
        [Route("KullaniciEkle")]
        [Nitelik.Loglama]
        public ActionResult KullaniciEkle([Bind(Include = "No,Ad,Soyad,DogumTarihi,Cinsiyet,Eposta,TcKimlikNo,KullaniciAdi,Parola,UnvanNo,BolumNo")] Kullanici kullanici)
        {

            if (ModelState.IsValid)
            {
                db.Kullanici.Add(kullanici);
                db.SaveChanges();
                return RedirectToAction("Index");
            }


            ViewBag.BolumNo = new SelectList(db.Bolum, "No", "Ad", kullanici.BolumNo);
            ViewBag.UnvanNo = new SelectList(db.Unvan, "No", "Ad", kullanici.UnvanNo);

            return View(kullanici);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}