using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Data;
using Centre.Excellence.Formation.Migrations.DCFormationMigrations;
using Centre.Excellence.Formation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Centre.Excellence.Formation.Controllers
{
    public class LoginController : Controller
    {
        private readonly DbAuthentification db;

        public LoginController(DbAuthentification _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            var Authentifie = HttpContext.User.Identity.IsAuthenticated;
            ViewData["Authentifie"] = Authentifie;
            Personne model = null;

            if(Authentifie)
            {
                model = db.Personnes.AsNoTracking().FirstOrDefault(p => p.Nom == HttpContext.User.Identity.Name);
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Personne model, string returnUrl)
        {
            Personne perso = null;
            var Authentifie = HttpContext.User.Identity.IsAuthenticated;
            ViewData["Authentifie"] = Authentifie;
            if(ModelState.IsValid)
            {
                perso = (from p in db.Personnes where p.Prenom.Equals(model.Prenom) && p.Password.Equals(model.Password) select p).FirstOrDefault();
                if(perso == null)
                {
                    FormsAuthentication.SetCoukie
                }
            }
        }
    }
}
