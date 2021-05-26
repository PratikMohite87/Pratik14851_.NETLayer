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
        }
        public IActionResult Index()
        {
            return View();
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
    }
}
