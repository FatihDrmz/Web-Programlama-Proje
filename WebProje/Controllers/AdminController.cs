using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class AdminController : Controller
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        DbContextOptionsBuilder<KurumsalDBContext> _optionsBuilder;

        public AdminController(IConfiguration configuration)
        {
            _configuration = configuration;
            _optionsBuilder = new DbContextOptionsBuilder<KurumsalDBContext>();
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
            _optionsBuilder.UseSqlServer(_connectionString);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
        }

        public IActionResult Index()
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var kategori = db.Kategori.ToList();
                return View(kategori);
            }
        }

        public ActionResult Profil()
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {

                var profil = db.Admin.ToList();
                return View(profil);
            }
        }

        public ActionResult Iletisim()
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {
                var iletisim = db.Iletisim.ToList();
                return View(iletisim);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {

                var login = db.Admin.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();
                if (login.Eposta == admin.Eposta && login.Sifre == admin.Sifre)
                {

                    HttpContext.Session.SetInt32("adminid", login.AdminId);
                    ViewData["admin"] = HttpContext.Session.GetInt32("adminid");

                    HttpContext.Session.SetString("eposta", login.Eposta);
                    ViewData["Eposta"] = HttpContext.Session.GetString("eposta");

                    HttpContext.Session.SetString("yetki", login.Yetki);

                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Uyari = "E-postanız yada şifreniz yanlış";
                }
                return View(admin);
            }
        }

        public ActionResult Logout()
        {

            //HttpContext.Session.SetString("adminid",null);
            ViewBag.Id = HttpContext.Session.GetString("adminid");

            //HttpContext.Session.SetString("eposta", null);
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Admin");
        }

    }
}
