using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Centre.Excellence.Formation.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUSer> userManager;
        private SignInManager<ApplicationUSer> signInManager;

        public AccountController(UserManager<ApplicationUSer> userMgr,
        SignInManager<ApplicationUSer> signinMgr)
        {
            userManager = userMgr;
            signInManager = signinMgr;
        }

        [AllowAnonymous]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
    }
}
