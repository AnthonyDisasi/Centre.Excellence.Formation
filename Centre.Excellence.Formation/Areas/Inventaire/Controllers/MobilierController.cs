using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Areas.Inventaire.Data;
using Microsoft.AspNetCore.Mvc;

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
        public string Index()
        {
            return "Salut";
        }
    }
}
