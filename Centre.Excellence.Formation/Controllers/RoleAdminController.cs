using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Centre.Excellence.Formation.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Centre.Excellence.Formation.Controllers
{
    public class RoleAdminController : Controller
    {
        private RoleManager<IdentityRole> roleManager;
        private UserManager<ApplicationUSer> userManager;

        public RoleAdminController(RoleManager<IdentityRole> _roleManager, UserManager<ApplicationUSer> userMrg)
        {
            roleManager = _roleManager; ;
            userManager = userMrg;
        }

        public ViewResult Index() => View(roleManager.Roles);
    }
}
