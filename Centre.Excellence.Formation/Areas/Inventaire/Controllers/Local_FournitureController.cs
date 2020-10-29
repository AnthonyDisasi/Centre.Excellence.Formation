using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Centre.Excellence.Formation.Areas.Inventaire.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            ViewBag.Localisations = new SelectList(db.Localisations, "ID", "Nom");
            ViewBag.Fournitures = new SelectList(db.Fournitures, "ID", "Nom");
        }

        public IActionResult newLocalisation(string nom)
        {
            Localisation model = new Localisation { Nom = nom };
            db.Localisations.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateFourniture(string nom)
        {
            Fourniture model = new Fourniture { Nom = nom };
            db.Fournitures.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public string Index()
        {
            return "Salut";
        }
    }
}
