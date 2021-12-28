using WebProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebProje.Models.DataContext;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace WebProje.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly KurumsalDBContext db;
     
        public HomeController(KurumsalDBContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return HizmetPartial();
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddYears(1) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

        public IActionResult HizmetPartial()
        {
            return View(db.Hizmet.ToList());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
