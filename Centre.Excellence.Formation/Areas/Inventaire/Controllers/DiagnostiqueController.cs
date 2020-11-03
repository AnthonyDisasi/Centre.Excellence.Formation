using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Centre.Excellence.Formation.Areas.Inventaire.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Centre.Excellence.Formation.Areas.Inventaire.Controllers
{
    [Area("Inventaire")]
    [Authorize(Roles = "Maintenancier")]
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
        public IActionResult Create(Diagnostique model, string idmat, string description, string marque)
        {
            model.MaterielID = idmat;
            if(ModelState.IsValid)
            {
                db.Diagnostiques.Add(model);
                db.SaveChanges();
                return RedirectToAction("Detail", "Materiel", new { id = idmat });
            }
            ViewBag.IDMateriel = idmat;
            ViewBag.Desc = description;
            ViewBag.Marq = marque;
            return View(model);
        }

        public IActionResult Update(string id)
        {
            var model = db.Diagnostiques.Include(m => m.Materiel).AsNoTracking().FirstOrDefault(d => d.ID == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Diagnostique model, string id, string idmat)
        {
            model.ID = id;
            model.MaterielID = idmat;
            if (ModelState.IsValid)
            {
                db.Diagnostiques.Update(model);
                db.SaveChanges();
                return RedirectToAction("Detail", "Materiel", new { id = idmat });
            }
            model.Materiel = db.Materiels.Find(idmat);
            return View(model);
        }

        [ActionName("Delete")]
        public IActionResult Supprimer(string id)
        {
            var model = db
                .Diagnostiques
                .Include(m => m.Materiel)
                .AsNoTracking()
                .FirstOrDefault(d => d.ID == id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Delete(string id)
        {
            Diagnostique model = db.Diagnostiques.Find(id);
            db.Diagnostiques.Remove(model);
            db.SaveChanges();
            return RedirectToAction("Detail", "Materiel", new { id = model.MaterielID });
        }

        public IActionResult Detail(string id)
        {
            var model = db
                .Diagnostiques
                .Include(m => m.Materiel)
                .AsNoTracking()
                .FirstOrDefault(d => d.ID == id);
            return View(model);
        }

        public IActionResult NewDiag()
        {
            ViewBag.Mat = new SelectList(db.Materiels, "ID", "Description");
            return View();
        }

        [HttpPost]
        public IActionResult NewDiag(Diagnostique model)
        {
            if(ModelState.IsValid)
            {
                db.Diagnostiques.Add(model);
                db.SaveChanges();
                return RedirectToAction("Detail", "Materiel", new { id = model.MaterielID });
            }
            ViewBag.Mat = new SelectList(db.Materiels, "ID", "Description");
            return View(model);
        }
    }
}
