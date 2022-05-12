using Abdülkadir_Şengül.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Abdülkadir_Şengül.Controllers
{
    public class OturumController : Controller
    {
        MakaleEntities baglan = new MakaleEntities();
        public ActionResult Giris()
        {
            return View();
        }

        [HttpPost]
        [Nitelik.Loglama]
        public ActionResult Giris(Kullanici yeni_bilgi)
        {

            if (yeni_bilgi.KullaniciAdi != null)
            {
                if (yeni_bilgi.Parola != null)
                {
                    var bilgi = baglan.Kullanici.FirstOrDefault(m => m.KullaniciAdi == yeni_bilgi.KullaniciAdi && m.Parola == yeni_bilgi.Parola);

                    if (bilgi != null)
                    {
                        FormsAuthentication.RedirectFromLoginPage(bilgi.No.ToString(), false);
                        return RedirectToAction("KullaniciEkle", "Kullanicis");
                    }
                    else
                    {
                        ViewBag.uyari = "Bilgilerinizi kontrol ediniz.";
                    }
                }
                else
                {
                    ViewBag.uyari = "Bilgilerinizi Yazınız!";
                }
            }
            else
            {
                ViewBag.uyari = "Bilgilerinizi Yazınız!";
            }

            return View();
        }
    }
}