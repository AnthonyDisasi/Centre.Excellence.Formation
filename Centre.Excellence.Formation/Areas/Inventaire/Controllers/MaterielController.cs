using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CentreFormation.Areas.Inventaire.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;

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
        public IActionResult Index()
        {
            return View();
        }
    }
}
