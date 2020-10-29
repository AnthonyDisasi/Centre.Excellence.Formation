using System;
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
    public class MobilierController : Controller
    {
        private readonly DCInventaire db;

        public MobilierController(DCInventaire _db)
        {
            db = _db;
        }

        private void LLocal()
        {
            List<SelectListItem> Localisation = (from l in db.Localisations orderby l.Nom ascending select new SelectListItem() { Text = l.Nom, Value = l.Nom }).ToList();
            ViewBag.Localisations = Localisation;
        }

        public IActionResult Create()
        {
            LLocal();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Mobilier model)
        {
            if(ModelState.IsValid)
            {
                db.Mobiliers.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            LLocal();
            return View(model);
        }

        public IActionResult Index()
        {
            var model = db.Mobiliers.AsNoTracking().ToList();
            return View(model);
        }
    }
}
