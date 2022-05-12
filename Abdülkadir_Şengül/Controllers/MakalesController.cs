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
    public class MakalesController : Controller
    {
        private MakaleEntities db = new MakaleEntities();
        public ActionResult Index()
        {
            var makale = db.Makale.Include(m => m.Dergi).Include(m => m.Endeks).Include(m => m.MakaleTur);
            return View(makale.ToList());
        }

        public ActionResult MakaleEkle()
        {
            ViewBag.DergiNo = new SelectList(db.Dergi, "No", "Ad");
            ViewBag.EndeksNo = new SelectList(db.Endeks, "No", "Ad");
            ViewBag.MakaleTuruNo = new SelectList(db.MakaleTur, "No", "Ad");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MakaleEkle([Bind(Include = "No,Ad,YayinTarihi,DergiNo,MakaleTuruNo,EndeksNo,Özet")] Makale makale)
        {
            if (ModelState.IsValid)
            {
                db.Makale.Add(makale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DergiNo = new SelectList(db.Dergi, "No", "Ad", makale.DergiNo);
            ViewBag.EndeksNo = new SelectList(db.Endeks, "No", "Ad", makale.EndeksNo);
            ViewBag.MakaleTuruNo = new SelectList(db.MakaleTur, "No", "Ad", makale.MakaleTuruNo);
            return View(makale);
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