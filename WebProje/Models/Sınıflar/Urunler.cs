using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProje.Models.Sınıflar
{
    public class Urunler
    {
        [Key]
        public int ID { get; set; }
        public string MarkaAdi { get; set; }
        public string UrunAdi { get; set; }
        public string Aciklama { get; set; }
        public string UrunFiyat { get; set; }
        public string UrunResimURL { get; set; }
        public string BaglantiTuru { get; set; }
        public string Dayaniklilik { get; set; }
        public string KullanimTipi { get; set; }
        public string GarantiSuresi { get; set; }
    }
}