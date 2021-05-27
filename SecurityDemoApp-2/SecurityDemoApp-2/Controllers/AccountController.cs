using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecurityDemoApp_2.ViewModels;
using SecurityDemoApp_2.Models;
using Microsoft.AspNetCore.Identity;

namespace SecurityDemoApp_2.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<MyIdentityUser> userManager;
        private readonly SignInManager<MyIdentityUser> signInManager;
        private readonly RoleManager<MyIdentityRole> roleManager;

        public AccountController(
            UserManager<MyIdentityUser> userManager,
            SignInManager<MyIdentityUser> signInManager,
            RoleManager<MyIdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;

            AddAdmin();
        }
        public IActionResult Index()
        {
            return View();
        }

        private void AddAdmin()
        {
            if (!roleManager.RoleExistsAsync("admin").Result)
            {
                MyIdentityRole role = new MyIdentityRole();
                role.Name = "admin";
                role.Description = "Administer Website";

                IdentityResult roleResult = roleManager.CreateAsync(role).Result;

                if (!roleResult.Succeeded)
                    ModelState.AddModelError("", "Error while creating role");
                else
                {
                    MyIdentityUser user = new MyIdentityUser();
                    user.UserName = "admin";
                    user.Email = "admin@test.com";
                    user.FullName = "site admin";

                    IdentityResult result = userManager.CreateAsync(user, "test12").Result;

                    userManager.AddToRoleAsync(user, "admin").Wait();
                }
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationViewModel obj)
        {
            if (ModelState.IsValid)
            {
                MyIdentityUser user = new MyIdentityUser()
                {
                    UserName = obj.UserName,
                    Email = obj.Email,
                    FullName = obj.FullName,
                    BirthDate = obj.BirthDate
                };

                IdentityResult result = userManager.CreateAsync(user, obj.Password).Result;     // user is created

                if (result.Succeeded)
                {
                    // assigning role to user
                    if (!roleManager.RoleExistsAsync("NormalUser").Result)
                    {
                        // if no then creating role
                        MyIdentityRole role = new MyIdentityRole();
                        role.Name = "NormalUser";
                        role.Description = "Perform normal operations.";

                        IdentityResult roleResult = roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Error while creating role !");
                            return View(obj);
                        }
                    }

                    userManager.AddToRoleAsync(user, "NormalUser").Wait();
                    return RedirectToAction("Login", "Account");     // goto login of account controller

                }
                else
                {
                    IEnumerable<IdentityError> errors = result.Errors;

                    foreach (var item in errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
           
            return View(obj);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var result = signInManager.PasswordSignInAsync(obj.UserName, obj.Password, obj.RememberMe, true).Result;

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");       // valid user
                }

                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "Account is locked");
                }

                ModelState.AddModelError("", "Invalid Login !");
            }

            return View(obj);       // failing server side validation.
        }

        public IActionResult LogOff()
        {
            signInManager.SignOutAsync().Wait();

            return RedirectToAction("Login","Account");
        }
    }
}
