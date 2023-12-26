using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebProje.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Adresler> Adreslers { get; set; }
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Hakkımızda> Hakkımızdas { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Markalar> Markalars { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
    }
}