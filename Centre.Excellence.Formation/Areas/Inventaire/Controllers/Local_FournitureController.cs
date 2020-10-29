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
    public class Local_FournitureController : Controller
    {
        private readonly DCInventaire db;

        public Local_FournitureController(DCInventaire _db)
        {
            db = _db;
        }

        private void Liste()
        {
            ViewBag.Localisations = db.Localisations.AsNoTracking().ToList();
            ViewBag.Fournitures = db.Fournitures.AsNoTracking().ToList();
        }

        public IActionResult newLocalisation(string nom)
        {
            Localisation model = new Localisation { Nom = nom };
            db.Localisations.Add(model);
            db.SaveChanges();
            Liste();
            return RedirectToAction("Index");
        }

        public IActionResult CreateFourniture(string nom)
        {
            Fourniture model = new Fourniture { Nom = nom };
            db.Fournitures.Add(model);
            db.SaveChanges();
            Liste();
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            Liste();
            return View();
        }

        public IActionResult UpdateLocal(string id, string nom)
        {
            Localisation model = new Localisation { ID = id, Nom = nom };
            db.Localisations.Update(model);
            db.SaveChanges();
            Liste();
            return RedirectToAction("Index");
        }
    }
}
