using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProje.Models.Sınıflar
{
    public class AdminPanelListe
    {
        public IEnumerable<Urunler> UrunListe { get; set; }
        public IEnumerable<Kullanici> KullaniciListe { get; set; }
    }
}