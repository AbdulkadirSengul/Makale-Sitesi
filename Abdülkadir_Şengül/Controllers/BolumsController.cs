using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Abdülkadir_Şengül.Models;

namespace Abdülkadir_Şengül.Controllers
{
    public class BolumsController : Controller
    {
        private MakaleEntities db = new MakaleEntities();

        [_KullaniciControl]
        public ActionResult Index()
        {
            return View(db.Bolum.ToList());
        }

        [_KullaniciControl]
        public ActionResult BolumEkle()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult BolumEkle([Bind(Include = "No,Ad")] Bolum bolum)
        {
            if (ModelState.IsValid)
            {
                db.Bolum.Add(bolum);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bolum);
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