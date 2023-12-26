using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models.Sınıflar;

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        AdminPanelListe apl = new AdminPanelListe();

        [Authorize]
        public ActionResult Index()
        {
            apl.UrunListe = c.Urunlers.ToList();
            apl.KullaniciListe = c.Kullanicis.ToList();

            if (Convert.ToString(Session["kullanici"]) == Convert.ToString("Admin"))
            {
                return View(apl);

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult UrunEkle()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public ActionResult UrunEkle(Urunler p)
        {
            c.Urunlers.Add(p);
            c.SaveChanges();
            return RedirectToAction("/Index");
        }
        [Authorize]
        public ActionResult UrunSil(int id)
        {
            var u = c.Urunlers.Find(id);
            c.Urunlers.Remove(u);
            c.SaveChanges();
            return RedirectToAction("/Index");
        }

        [Authorize]
        public ActionResult UrunGetir(int id)
        {
            var u = c.Urunlers.Find(id);
            return View("UrunGetir", u);
        }
        [Authorize]
        public ActionResult UrunGuncelle(Urunler p)
        {
            var urun = c.Urunlers.Find(p.ID);

            urun.MarkaAdi = p.MarkaAdi;
            urun.UrunAdi = p.UrunAdi;
            urun.Aciklama = p.Aciklama;
            urun.UrunResimURL = p.UrunResimURL;
            urun.UrunFiyat = p.UrunFiyat;
            urun.BaglantiTuru = p.BaglantiTuru;
            urun.Dayaniklilik = p.Dayaniklilik;
            urun.KullanimTipi = p.KullanimTipi;
            urun.GarantiSuresi = p.GarantiSuresi;

            c.SaveChanges();
            return RedirectToAction("/Index");
        }
        [Authorize]
        public ActionResult KullaniciSil(int id)
        {
            var u = c.Kullanicis.Find(id);
            c.Kullanicis.Remove(u);
            c.SaveChanges();
            return RedirectToAction("/Index");
        }
        [Authorize]
        public ActionResult KullaniciGetir(int id)
        {
            var u = c.Kullanicis.Find(id);
            return View("KullaniciGetir", u);
        }
        [Authorize]
        public ActionResult KullaniciGuncelle(Kullanici kl)
        {
            var kullanici = c.Kullanicis.Find(kl.ID);

            kullanici.Rol = kl.Rol;
            c.SaveChanges();
            return RedirectToAction("/Index");
        }
    }
}