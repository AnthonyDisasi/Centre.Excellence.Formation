using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Centre.Excellence.Formation.Areas.Inventaire.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Centre.Excellence.Formation.Areas.Inventaire.Controllers
{
    [Area("Inventaire")]
    public class MaterielController : Controller
    {
        private readonly DCInventaire db;
        public MaterielController(DCInventaire _db)
        {
            db = _db;
        }

        private void LFourniture()
        {
            List<SelectListItem> Fournitures = (from f in db.Fournitures orderby f.Nom ascending select new SelectListItem() { Text = f.Nom, Value = f.Nom }).ToList();
            ViewBag.Fournitures = Fournitures;
        }

        private void LLocal()
        {
            List<SelectListItem> Localisation = (from l in db.Localisations orderby l.Nom ascending select new SelectListItem() { Text = l.Nom, Value = l.Nom }).ToList();
            ViewBag.Localisations = Localisation;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = from m in db.Materiels select m;
            return View(await model.AsNoTracking().ToListAsync());
        }

        public IActionResult Create()
        {
            LFourniture();
            LLocal();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Materiel model)
        {
            if (ModelState.IsValid)
            {
                db.Materiels.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index", "Materiel");
            }
            LFourniture();
            LLocal();
            return View();
        }
    }
}
