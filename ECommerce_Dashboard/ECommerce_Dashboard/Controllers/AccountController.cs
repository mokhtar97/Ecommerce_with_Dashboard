using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using ECommerce_Dashboard.Models;
using ECommerce_Dashboard.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace ECommerce_Dashboard.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signinManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signinManager)
        {
            this.userManager = userManager;
            this.signinManager = signinManager;
        }


        public async Task<List<IdentityUser>> GetUsersAsync()
        {
            using (var context = new ApplicationDbContext())
            {
                return await userManager.Users.ToListAsync();
            }
        }

        [HttpGet]
        public IActionResult create()
        {
            return PartialView();
        }


        [HttpPost]
        public async Task<IActionResult> create(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Name, Email = model.Email ,PhoneNumber=model.Phone};
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return PartialView(model);
        }


        [HttpGet]
        public IActionResult createAdmin()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> createAdmin(UserModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Name, Email = model.Email, PhoneNumber = model.Phone };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("IndexAdmins");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return PartialView(model);
        }
        public async Task<IActionResult> Index()
        {

            using (var context = new ApplicationDbContext())
            {
                var users = await userManager.Users.ToListAsync();
                List<UserData> usersdata = new List<UserData>();
                foreach (var item in users)
                {
                    usersdata.Add(new UserData { Name = item.UserName, Email = item.Email, Phone = item.PhoneNumber, ID = item.Id });
                }
                return PartialView(usersdata);
            }
           
        }


        public async Task<IActionResult> IndexAdmins()
        {

            using (var context = new ApplicationDbContext())
            {
                var users = await userManager.GetUsersInRoleAsync("Admin");
                List<UserData> usersdata = new List<UserData>();
                foreach (var item in users)
                {
                    usersdata.Add(new UserData { Name = item.UserName, Email = item.Email, Phone = item.PhoneNumber, ID = item.Id });
                }
                return PartialView(usersdata);
            }

        }

        public IActionResult Details(string id)
        {
            
            var users = userManager.Users.Where(u => u.Id == id).FirstOrDefault();
            UserData userdata = new UserData();
            userdata.Name = users.UserName;
            userdata.Email = users.Email;
            userdata.Phone = users.PhoneNumber;
            userdata.ID = users.Id;
            return PartialView(userdata);

        }



        public ActionResult Edit(string id)
        {
            var user = userManager.Users.Where(u => u.Id == id).FirstOrDefault();
            var userd = new UserData();
            userd.Name = user.UserName;
            userd.Phone = user.PhoneNumber;
            userd.Email = user.Email;
            return PartialView(userd);
        }


        [HttpPost]

        public async Task<ActionResult> Edit([Bind("ID,Name,Email,Phone")] UserData userData)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            var id = userData.ID;
            var user =userManager.Users.Where(u => u.Id == id).FirstOrDefault(); ;
            user.UserName = userData.Name;
            user.Email = userData.Email;
            user.PhoneNumber = userData.Phone;
           var result= await userManager.UpdateAsync(user);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return PartialView(userData);
            }
            
        }


        public async Task<ActionResult> Delete(string id)
        {
            var user = userManager.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

           await userManager.DeleteAsync(user);

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
                    var result = await signinManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
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