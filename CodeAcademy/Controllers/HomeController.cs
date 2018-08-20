﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CodeAcademy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using CodeAcademy.Models.ViewModels;

namespace CodeAcademy.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        UserManager<User> _userManager;
        SignInManager<User> _signInManager;
        RoleManager<IdentityRole> _roleManager;
        AppDbContext _dbContext;

        public HomeController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager,AppDbContext dbContext)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Login()
        {
            var allUsers = _userManager.Users.ToList();
            return View(new LoginViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByEmailAsync(model.Email);
                    if (await _userManager.IsInRoleAsync(user, "Admin"))
                        return RedirectToAction("Index","Home", new { area = "Admin"});
                }
            }
            return View();
        }

    }
}
