using Abdülkadir_Şengül.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abdülkadir_Şengül.Controllers
{

    public class AnaSayfaController : Controller
    {
        MakaleEntities contact = new MakaleEntities();
        public ActionResult AnaSayfa()
        {
            var makale_liste = contact.Makale.ToList();
            return View(makale_liste);
        }

        public ActionResult _Kategoriler()
        {
            var kategori_Liste = contact.Kategori.ToList();
            return PartialView(kategori_Liste);
        }

        public ActionResult _Yazar()
        {
            var yazar_liste = contact.MakaleYazar.ToList();
            return PartialView(yazar_liste);
        }

    }
}