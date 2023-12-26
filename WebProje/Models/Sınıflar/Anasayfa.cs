using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProje.Models.Sınıflar
{
    public class Anasayfa
    {
        [Key]
        public int ID { get; set; }
        public string BannerURL { get; set; }
    }
}