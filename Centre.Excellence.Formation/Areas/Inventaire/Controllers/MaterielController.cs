using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentreFormation.Areas.Inventaire.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.AspNetCore.Mvc.Rendering;

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

        public IActionResult Index()
        {
            return View();
        }
    }
}
