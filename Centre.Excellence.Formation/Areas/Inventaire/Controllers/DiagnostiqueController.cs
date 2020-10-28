using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Centre.Excellence.Formation.Areas.Inventaire.Controllers
{
    public class DiagnostiqueController : Controller
    {
        public IActionResult Create(string idmat)
        {
            ViewBag.IDMateriel = idmat;
            return View();
        }
    }
}
