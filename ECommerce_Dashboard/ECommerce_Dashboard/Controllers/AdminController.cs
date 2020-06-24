using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce_Dashboard.Models;
using ECommerce_Dashboard.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce_Dashboard.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly UserManager<IdentityUser> userManager;

        public AdminController(RoleManager<IdentityRole> roleManager,SignInManager<IdentityUser> signInManager, UserManager<IdentityUser> userManager)
        {
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            List<IdentityRole> roles = roleManager.Roles.ToList();
            List<RoleVM> rolVms = new List<RoleVM>();
            foreach (var item in roles)
            {
                rolVms.Add(new RoleVM { RoleName = item.Name });
            }
            return PartialView(rolVms.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RoleVM role)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = role.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                  return RedirectToAction("Index");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return PartialView("role");
        }

      
        [HttpGet]
        public async Task<IActionResult> Delete(string name)
        {
         var role = roleManager.Roles.Where(r => r.Name == name).FirstOrDefault();
            if (role == null)
            {
                return NotFound();
            }

            await roleManager.DeleteAsync(role);

            return RedirectToAction("Index");
         }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);
                var res = await userManager.IsInRoleAsync(user, "Admin");

                if (res == true)
                {
                    var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                    if (result.Succeeded)
                    {  
                            return RedirectToAction("Index", "Home");         
                    }
                   
                }
                ModelState.AddModelError("", "Invalid Login");
            }
            return View("Login", model);
        }

    }
}