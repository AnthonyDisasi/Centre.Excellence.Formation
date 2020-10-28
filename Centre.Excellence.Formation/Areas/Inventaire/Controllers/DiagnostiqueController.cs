using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Centre.Excellence.Formation.Areas.Inventaire.Controllers
{
    public class DiagnostiqueController : Controller
    {
        public IActionResult Create(string idmat, string description, string marque)
        {
            ViewBag.IDMateriel = idmat;
            ViewBag.Desc = description;
            ViewBag.Marq = marque;
            return View();
        }
    }
}
