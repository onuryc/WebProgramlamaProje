using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProje.Models.Sınıflar
{
    public class Kullanici
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Lütfen adınzı girin.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı girin.")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen email adresinizi girin.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen sifrenizi girin.")]
        public string Sifre { get; set; }
        public string Rol { get; set; } = "User";
    }
}