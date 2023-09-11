using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Asset.Models;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Asset.Data;
using Microsoft.AspNetCore.Identity;

namespace Asset.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;

        public AccountController(SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(IdentityUser model)
        {
            var user = new IdentityUser { UserName = model.UserName, Email = model.Email,NormalizedUserName = model.NormalizedUserName };
            if (ModelState.IsValid)
            {
                var result = await _userManager.CreateAsync(user,model.PasswordHash);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(model, isPersistent: false);
                    return RedirectToAction("Dashboard", "Dashboard"); // Redirect to a success page
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            // If registration fails, redisplay the registration form with errors
            return View(model);
        }


        [HttpGet]
        public IActionResult Login()
        {
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync (model.Email);

                if (user != null)
                {
                   
                    //var password = new PasswordHasher<IdentityUser>().HashPassword(null, model.PasswordHash);
                    var result = await _signInManager.PasswordSignInAsync (model.Email, model.Password ,false,false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Dashboard", "Dashboard"); // Redirect to a success page
                    }
                   
                   else
                    {
                        ModelState.AddModelError("", "Invalid Password");
                    }
                }
               
                ModelState.AddModelError("", "Invalid login attempt");
            }
            //return View(model);
            return RedirectToAction("Index", "Home");
            // Handle invalid login here (e.g., return a view with an error message).
           // ModelState.AddModelError(string.Empty, "Invalid login attempt");
            //return View(model);
        }

        // Other actions...
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
