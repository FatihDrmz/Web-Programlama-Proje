using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
    public class BlogController : Controller
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<KurumsalDBContext> _optionsBuilder;

        public BlogController(IConfiguration configuration)
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
                //  _optionsBuilder.UseLazyLoadingProxies(false);
                var blog = db.Blog.Include("Kategori").ToList().OrderByDescending(x=>x.BlogId);
                return View(blog);
            }
        }

        public IActionResult Create()
        {
            //ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "KategoriAd");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Blog blog, IFormFile ResimURL)
        {
            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    if (ResimURL != null)
                    {

                        WebImage img = new WebImage(ResimURL.OpenReadStream());
                        FileInfo imginfo = new FileInfo(ResimURL.FileName);

                        string blogname = Guid.NewGuid().ToString() + imginfo.Extension;

                        img.Resize(500, 500);

                        // img.Save("~/Uploads/Hizmet/" + logoname);

                       blog.ResimURL = "/Uploads/Blog/" + blogname;
                    }

                    db.Blog.Add(blog);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(blog);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                ViewBag.Uyari = "Güncellenecek Blog Bulunamadı.";
            }
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var blog = db.Blog.Find(id);

                if (blog == null)
                {
                    return NotFound();
                }
                ViewBag.KategoriId = new SelectList(db.Kategori, "KategoriId", "KategoriAd", blog.KategoriId);
                return View(blog);
            }      
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int? id, Blog blog, IFormFile ResimURL)
        {

            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    var b = db.Blog.Where(x => x.BlogId == id).SingleOrDefault();

                    if (ResimURL != null)
                    {
                        if (System.IO.File.Exists(Path.GetExtension(b.ResimURL)))
                        {
                            System.IO.File.Delete(Path.GetExtension(b.ResimURL));
                        }

                        WebImage img = new WebImage(ResimURL.OpenReadStream());
                        FileInfo imginfo = new FileInfo(ResimURL.FileName);

                        string blogname = Guid.NewGuid().ToString() + imginfo.Extension;

                        img.Resize(600, 400);

                        // img.Save("~/Uploads/Hizmet/" + logoname);

                        b.ResimURL = "/Uploads/Blog/" + blogname;
                    }

                    b.Baslik = blog.Baslik;
                    b.Icerik = blog.Icerik;
                    b.KategoriId = blog.KategoriId;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(blog);
        }


        public ActionResult Delete(int id)
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var blog = db.Blog.Find(id);

                if (blog == null)
                {
                    return NotFound();
                }  

                if (System.IO.File.Exists(Path.GetExtension(blog.ResimURL)))
                {
                    System.IO.File.Delete(Path.GetExtension(blog.ResimURL));
                }

                db.Blog.Remove(blog);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}
