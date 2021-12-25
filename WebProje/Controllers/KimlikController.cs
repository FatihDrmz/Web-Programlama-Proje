using Microsoft.AspNetCore.Hosting;
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
    public class KimlikController : Controller
    {

        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<KurumsalDBContext> _optionsBuilder;
   
        public KimlikController(IConfiguration configuration)
        {
            _configuration = configuration;
            _optionsBuilder = new DbContextOptionsBuilder<KurumsalDBContext>();
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
            _optionsBuilder.UseSqlServer(_connectionString);
        }
        
        // GET: KimlikController
        public ActionResult Index()
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var kimlik = db.Kimlik.ToList();
                return View(kimlik);
            }
        }

        // GET: KimlikController/Edit/5
        public ActionResult Edit(int id)
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var kimlik = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();
                return View(kimlik);
            }
        }
     
        // POST: KimlikController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Kimlik kimlik, IFormFile LogoURL)
        {
            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    var k = db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();

                    if (LogoURL != null)
                    {

                        if (System.IO.File.Exists(Path.GetExtension(k.LogoURL)))
                        {
                            System.IO.File.Delete(Path.GetExtension(k.LogoURL));
                        }

                        WebImage img = new WebImage(LogoURL.OpenReadStream());
                        FileInfo imginfo = new FileInfo(LogoURL.FileName);

                        string logoname = Guid.NewGuid().ToString() + imginfo.Extension;
                        
                        img.Resize(200, 200);
                      
                      //  img.Save("~/Uploads/Kimlik/" + logoname);

                        k.LogoURL = "~/Uploads/Kimlik/"+logoname ;
                    }
                    
                    k.Title = kimlik.Title;
                    k.Keywords = kimlik.Keywords;
                    k.Description = kimlik.Description;
                    k.Unvan = kimlik.Unvan;

                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(kimlik);
        }
    }
}
