using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class HakkimizdaController : Controller
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<KurumsalDBContext> _optionsBuilder;

        public HakkimizdaController(IConfiguration configuration)
        {
            _configuration = configuration;
            _optionsBuilder = new DbContextOptionsBuilder<KurumsalDBContext>();
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
            _optionsBuilder.UseSqlServer(_connectionString);
        }

        public IActionResult Index()
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var hakkimizda = db.Hakkimizda.ToList();
                return View(hakkimizda);
            }
        }

        public ActionResult Edit(int id)
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var hakkimizda = db.Hakkimizda.Where(x => x.HakkimizdaId == id).SingleOrDefault();
                return View(hakkimizda);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Hakkimizda hakkimizda)
        {
            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    var h = db.Hakkimizda.Where(x => x.HakkimizdaId == id).SingleOrDefault();

                    h.Aciklama = hakkimizda.Aciklama;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(hakkimizda);
        }


    } 
}
