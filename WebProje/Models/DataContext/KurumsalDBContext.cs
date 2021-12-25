using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using WebProje.Models.Model;

namespace WebProje.Models.DataContext
{
    public class KurumsalDBContext :DbContext
    {
        public KurumsalDBContext(DbContextOptions<KurumsalDBContext> options) : base(options)
        {
          
        }

        public DbSet<Admin> Admin { get; set; }

        public DbSet<Blog> Blog { get; set; }
   
        public DbSet<Hakkimizda> Hakkimizda { get; set; }

        public DbSet<Hizmet> Hizmet { get; set; }

        public DbSet<Iletisim> Iletisim { get; set; }

        public DbSet<Kategori> Kategori { get; set; }

        public DbSet<Kimlik> Kimlik { get; set; }

        public DbSet<Slider> Slider { get; set; }

    }
}
