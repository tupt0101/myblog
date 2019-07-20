using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_Blog.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Blog.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            var user = await _userManager.FindByEmailAsync(vm.Email);
            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, vm.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(vm.Role))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(vm);
        }
    }
}