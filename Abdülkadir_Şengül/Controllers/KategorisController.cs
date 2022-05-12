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
    public class KategorisController : Controller
    {
        private MakaleEntities db = new MakaleEntities();

        [_KullaniciControl]
        public ActionResult Index()
        {
            return View(db.Kategori.ToList());
        }


        [_KullaniciControl]
        [Route("KategoriEkle")]
        public ActionResult KategoriEkle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("KategoriEkle")]
        public ActionResult KategoriEkle([Bind(Include = "No,Ad")] Kategori kategori)
        {
            if (ModelState.IsValid)
            {
                db.Kategori.Add(kategori);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kategori);
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