using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class SliderController : Controller
    {
        private readonly KurumsalDBContext _context;

        public SliderController(KurumsalDBContext context)
        {
            _context = context;
        }

        // GET: Slider
        public async Task<IActionResult> Index()
        {
            return View(await _context.Slider.ToListAsync());
        }

        // GET: Slider/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Slider
                .FirstOrDefaultAsync(m => m.SliderId == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // GET: Slider/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Slider/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SliderId,Baslik,Aciklama,ResimURL")] Slider slider, IFormFile ResimURL)
        {
            if (ModelState.IsValid)
            {
                if (ResimURL != null)
                {

                    WebImage img = new WebImage(ResimURL.OpenReadStream());
                    FileInfo imginfo = new FileInfo(ResimURL.FileName);

                    string slidername = Guid.NewGuid().ToString() + imginfo.Extension;

                    img.Resize(1024, 768);

                    // img.Save("~/Uploads/Hizmet/" + logoname);

                    slider.ResimURL = "/Uploads/Slider/" + slidername;
                }

                _context.Add(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slider);
        }

        // GET: Slider/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Slider.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        // POST: Slider/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SliderId,Baslik,Aciklama,ResimURL")] Slider slider, IFormFile ResimURL)
        {

            if (ModelState.IsValid)
            {
                    var s = _context.Slider.Where(x => x.SliderId == id).SingleOrDefault();

                    if (ResimURL != null)
                    {
                        if (System.IO.File.Exists(Path.GetExtension(s.ResimURL)))
                        {
                            System.IO.File.Delete(Path.GetExtension(s.ResimURL));
                        }

                        WebImage img = new WebImage(ResimURL.OpenReadStream());
                        FileInfo imginfo = new FileInfo(ResimURL.FileName);

                        string blogname = Guid.NewGuid().ToString() + imginfo.Extension;

                        img.Resize(600, 400);

                        // img.Save("~/Uploads/Hizmet/" + logoname);

                        s.ResimURL = "/Uploads/Blog/" + blogname;
                    }

                    s.Baslik = slider.Baslik;
                    s.Aciklama = slider.Aciklama;
              
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                
            }
            return View(slider);
        }

        // GET: Slider/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slider = await _context.Slider
                .FirstOrDefaultAsync(m => m.SliderId == id);
            if (slider == null)
            {
                return NotFound();
            }

            return View(slider);
        }

        // POST: Slider/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var slider = await _context.Slider.FindAsync(id);
            if (System.IO.File.Exists(Path.GetExtension(slider.ResimURL)))
            {
                System.IO.File.Delete(Path.GetExtension(slider.ResimURL));
            }

            _context.Slider.Remove(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SliderExists(int id)
        {
            return _context.Slider.Any(e => e.SliderId == id);
        }
    }
}
