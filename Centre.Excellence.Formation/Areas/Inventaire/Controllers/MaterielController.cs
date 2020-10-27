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

        public IActionResult CreateFourniture(string nom)
        {
            Fourniture model = new Fourniture { Nom = nom };
            db.Fournitures.Add(model);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult newLocalisation(string nom)
        {
            Localisation model = new Localisation { Nom = nom };
            db.Localisations.Add(model);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        private void LLocal()
        {
            List<SelectListItem> Localisation = (from l in db.Localisations orderby l.Nom ascending select new SelectListItem() { Text = l.Nom, Value = l.Nom }).ToList();
            ViewBag.Localisations = Localisation;
        }

        public async Task<IActionResult> Index()
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
                return RedirectToAction("Index");
            }
            LFourniture();
            LLocal();
            return View();
        }

        public IActionResult Detail(string id)
        {
            Materiel model = db.Materiels.Include(d => d.Diagnostiques).AsNoTracking().FirstOrDefault(m => m.ID == id);
            LFourniture();
            LLocal();
            return View(model);
        }
    }
}
