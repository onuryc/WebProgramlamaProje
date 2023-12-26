using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models.Sınıflar;


namespace WebProje.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Context c = new Context();
        AnasayfaListe asl = new AnasayfaListe();
        public ActionResult Index()
        {
            asl.BannerListe = c.Anasayfas.ToList();
            asl.UrunListe = c.Urunlers.ToList();
            asl.MarkaListe = c.Markalars.ToList();
            return View(asl);
        }
    }
}