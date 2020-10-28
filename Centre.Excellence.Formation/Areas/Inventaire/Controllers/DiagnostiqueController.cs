using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Centre.Excellence.Formation.Areas.Inventaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace Centre.Excellence.Formation.Areas.Inventaire.Controllers
{
    public class DiagnostiqueController : Controller
    {
        private readonly DCInventaire db;

        public DiagnostiqueController(DCInventaire _db)
        {
            db = _db;
        }

        public IActionResult Create(string idmat, string description, string marque)
        {
            ViewBag.IDMateriel = idmat;
            ViewBag.Desc = description;
            ViewBag.Marq = marque;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Diagnostique model, string idmat)
        {
            model.MaterielID = idmat;
            if(ModelState.IsValid)
            {
                
            }
        }
    }
}
