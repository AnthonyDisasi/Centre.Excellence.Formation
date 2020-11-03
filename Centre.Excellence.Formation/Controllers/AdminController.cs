using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Centre.Excellence.Formation.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<ApplicationUSer> UserMana;
        private IUserValidator<ApplicationUSer> userValidator;
        private IPasswordValidator<ApplicationUSer> passwordValidator;
        private IPasswordHasher<ApplicationUSer> passwordHasher;

        public IActionResult Index()
        {
            return View();
        }
    }
}
