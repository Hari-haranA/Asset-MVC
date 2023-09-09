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
        private readonly SignInManager<LoginModel> _signInManager;
        private readonly UserManager<LoginModel> _userManager;

        public AccountController(SignInManager<LoginModel> signInManager, UserManager<LoginModel> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
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
                var user = await _userManager.FindByNameAsync (model.UserName);

                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password,false,false);

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
            return View(model);
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
