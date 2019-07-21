using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_Blog.Interfaces;
using FinalProject_Blog.Models;
using FinalProject_Blog.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;

namespace FinalProject_Blog.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;

        public AccountController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login([Bind] LoginViewModel vm)
        {
            if (!ModelState.IsValid)
                return View(vm);
            User u = _userManager.CheckLogin(vm.Email, vm.Password);
            if (u.Role != null)
            {
                if (u.Role.Equals("Admin"))
                {
                    UserSession userSession = new UserSession();
                    userSession.Email = u.Email;
                    userSession.Role = u.Role;
                    HttpContext.Session.SetString("USER_SESSION", u.Role);
                    return RedirectToAction("Index", "Admin");
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Login", "Account");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("USER_SESSION");
            return RedirectToAction("Login", "Account");
        }
    }
}