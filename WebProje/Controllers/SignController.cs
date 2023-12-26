using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebProje.Models.Sınıflar;

namespace WebProje.Controllers
{
    public class SignController : Controller
    {
        Context c = new Context();
        // GET: Sign
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Kullanici kl)
        {
            var kontrol = c.Kullanicis.FirstOrDefault(
                x => x.Email == kl.Email && x.Sifre == kl.Sifre
                );

            if (kontrol != null)
            {
                FormsAuthentication.SetAuthCookie(kontrol.Rol, false);
                Session["kullanici"] = kontrol.Rol.ToString();
                if (kontrol.Rol == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public ActionResult SignIn(Kullanici kl)
        {
            c.Kullanicis.Add(kl);
            c.SaveChanges();
            return RedirectToAction("/Index");
        }

        public ActionResult LogOut()
        {
            Session["kullanici"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
        
    }
}