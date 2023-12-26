using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models.Sınıflar;

namespace WebProje.Controllers
{
    public class ProductsController : Controller
    {
        Context c = new Context();
        // GET: Products
        public ActionResult Index()
        {
            var degerler = c.Urunlers.ToList();
            return View(degerler);
        }

        public ActionResult UrunDetay(int id)
        {
            var u = c.Urunlers.Where(x => x.ID == id).ToList();
            return View(u);
        }
    }
}