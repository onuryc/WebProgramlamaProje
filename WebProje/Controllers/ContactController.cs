using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models.Sınıflar;

namespace WebProje.Controllers
{
    public class ContactController : Controller
    {
        Context c = new Context();
        // GET: Contact
        public ActionResult Index()
        {
            var degerler = c.Adreslers.ToList();
            return View(degerler);
        }
    }
}