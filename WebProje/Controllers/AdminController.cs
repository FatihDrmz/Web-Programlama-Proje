using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(Admin admin)
        {
            if (ModelState.IsValid)
            {
                using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
                {
                    db.Admin.Add(admin);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Admin");
                }
            }
            return View(admin);
        }

        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            using (KurumsalDBContext db = new KurumsalDBContext(_optionsBuilder.Options))
            {

                var login = db.Admin.FirstOrDefault(x => x.Eposta == admin.Eposta && x.Sifre == admin.Sifre);
                if (login != null) 
                {
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name,admin.Eposta)
                    };
                    var useridenty = new ClaimsIdentity(claims,"Login");
                    ViewData["Eposta"] = claims;
                    ClaimsPrincipal principal = new ClaimsPrincipal(useridenty);
                    HttpContext.SignInAsync(principal);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    ViewBag.Uyari = "E-postanız yada şifreniz yanlış";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Admin");
        }


    }
}
