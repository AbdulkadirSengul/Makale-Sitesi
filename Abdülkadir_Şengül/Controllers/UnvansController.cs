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
    public class UnvansController : Controller
    {
        private MakaleEntities db = new MakaleEntities();

        [_KullaniciControl]
        public ActionResult Index()
        {
            return View(db.Unvan.ToList());
        }

        [_KullaniciControl]
        public ActionResult UnvanEKle()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UnvanEkle([Bind(Include = "No,Ad,KisaAd")] Unvan unvan)
        {
            if (ModelState.IsValid)
            {
                db.Unvan.Add(unvan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(unvan);
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