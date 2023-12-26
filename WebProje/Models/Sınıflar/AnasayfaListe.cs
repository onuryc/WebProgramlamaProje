using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace WebProje.Models.Sınıflar
{
    public class AnasayfaListe
    {
        public IEnumerable<Anasayfa> BannerListe { get; set; }
        public IEnumerable<Urunler> UrunListe { get; set; }

        public IEnumerable<Markalar> MarkaListe { get; set; }
    }
}