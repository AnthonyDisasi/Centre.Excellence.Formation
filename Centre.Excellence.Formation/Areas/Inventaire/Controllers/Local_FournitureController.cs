using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Centre.Excellence.Formation.Areas.Inventaire.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult newLocalisation(string nom)
        {
            Localisation model = new Localisation { Nom = nom };
            db.Localisations.Add(model);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult CreateFourniture(string nom)
        {
            Fourniture model = new Fourniture { Nom = nom };
            db.Fournitures.Add(model);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
