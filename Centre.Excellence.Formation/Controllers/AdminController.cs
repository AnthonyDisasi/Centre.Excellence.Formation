﻿using System.Threading.Tasks;
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

        public AdminController(UserManager<ApplicationUSer> usrMgr,
        IUserValidator<ApplicationUSer> userValid,
        IPasswordValidator<ApplicationUSer> passValid,
        IPasswordHasher<ApplicationUSer> passwordHash)
        {
            UserMana = usrMgr;
            userValidator = userValid;
            passwordValidator = passValid;
            passwordHasher = passwordHash;
        }

        public ViewResult Index() => View(UserMana.Users);

        public ViewResult Create() => View();

        [HttpPost]
        public async Task<IActionResult> Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUSer user = new ApplicationUSer
                {
                    UserName = model.Name,
                    Email = model.Email
                };
                IdentityResult result = await UserMana.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            ApplicationUSer user = await UserMana.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await UserMana.DeleteAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    AddErrorsFromResult(result);
                }
            }
            else
            {
                ModelState.AddModelError("", "Error Not Found");
            }
            return RedirectToAction("Index", UserMana.Users);
        }

        private void AddErrorsFromResult(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
        }

        public async Task<IActionResult> Edit(string id)
        {
            ApplicationUSer user = await UserMana.FindByIdAsync(id);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, string email, string password)
        {
            ApplicationUSer user = await UserMana.FindByIdAsync(id);
            if (user != null)
            {
                user.Email = email;
                IdentityResult validEmail = await userValidator.ValidateAsync(UserMana, user);
                if (!validEmail.Succeeded)
                {
                    AddErrorsFromResult(validEmail);
                }
                IdentityResult validPass = null;
                if (!string.IsNullOrEmpty(password))
                {
                    validPass = await passwordValidator.ValidateAsync(UserMana, user, password);
                    if (validPass.Succeeded)
                    {
                        user.PasswordHash = passwordHasher.HashPassword(user, password);
                    }
                    else
                    {
                        AddErrorsFromResult(validPass);
                    }
                }
                if ((validEmail.Succeeded && validPass == null) || (validEmail.Succeeded && password != string.Empty && validPass.Succeeded))
                {
                    IdentityResult result = await UserMana.UpdateAsync(user);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        AddErrorsFromResult(result);
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "User Not Found");
            }
            return View(user);
        }
    }
}
