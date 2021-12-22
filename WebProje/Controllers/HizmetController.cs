using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class HizmetController : Controller
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<KurumsalDBContext> _optionsBuilder;

        public HizmetController(IConfiguration configuration)
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
                var hizmet = db.Hizmet.ToList();
                return View(hizmet);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Hizmet hizmet, IFormFile ResimURL)
        {
            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    if (ResimURL != null)
                    {

                        WebImage img = new WebImage(ResimURL.OpenReadStream());
                        FileInfo imginfo = new FileInfo(ResimURL.FileName);

                        string hizmetname = Guid.NewGuid().ToString() + imginfo.Extension;

                        img.Resize(500, 500);

                        // img.Save("~/Uploads/Hizmet/" + logoname);

                        hizmet.ResimURL = "/Uploads/Hizmet/" + hizmetname;
                    }

                    db.Hizmet.Add(hizmet);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(hizmet);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.Uyari = "Güncellenecek Hizmet Bulunamadı.";
            }

            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var hizmet = db.Hizmet.Find(id);

                if (hizmet == null)
                {
                    return NotFound();
                }

                return View(hizmet);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Hizmet hizmet, IFormFile ResimURL)
        {
            
            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    var h = db.Hizmet.Where(x => x.HizmetId == id).SingleOrDefault();

                    if (ResimURL != null)
                    {
                        if (System.IO.File.Exists(Path.GetExtension(h.ResimURL)))
                        {
                            System.IO.File.Delete(Path.GetExtension(h.ResimURL));
                        }

                        WebImage img = new WebImage(ResimURL.OpenReadStream());
                        FileInfo imginfo = new FileInfo(ResimURL.FileName);

                        string hizmetname = Guid.NewGuid().ToString() + imginfo.Extension;

                        img.Resize(500, 500);

                        // img.Save("~/Uploads/Hizmet/" + logoname);

                        h.ResimURL = "/Uploads/Hizmet/" + hizmetname;
                    }

                    h.Baslik = hizmet.Baslik;
                    h.Aciklama = hizmet.Aciklama;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(hizmet);
        }

        public ActionResult Delete(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var hizmet = db.Hizmet.Find(id);

                if (hizmet == null)
                {
                    return NotFound();
                }

                db.Hizmet.Remove(hizmet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
