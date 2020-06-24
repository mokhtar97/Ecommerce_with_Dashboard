using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AccountController : ApiController
    {
        public async Task<IHttpActionResult> postUser(UserModel usermodel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //usermanager
            ApplicationDbContext context = new ApplicationDbContext();
            UserStore<IdentityUser> store = new UserStore<IdentityUser>(context);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            IdentityUser user = new IdentityUser();
            user.UserName = usermodel.Name;
            user.PasswordHash = usermodel.Password;
            user.Email = usermodel.Email;
            user.PhoneNumber = usermodel.Phone;
            
            //create
            IdentityResult result = await manager.CreateAsync(user, usermodel.Password);
            //ok
            if (result.Succeeded)
                return Created("", "User Added");
            else
                return BadRequest(result.Errors.ToList()[0]);

            //badrequest
        }

        public ICollection<UserData> GetUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            UserStore<IdentityUser> store = new UserStore<IdentityUser>(context);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            var users = manager.Users.Where(u => u.UserName.Length > 1);
            List<UserData> usersdata = new List<UserData>();
            foreach (var item in users)
            {
                usersdata.Add(new UserData { Name = item.UserName, Email = item.Email, Phone = item.PhoneNumber, ID = item.Id });
            }
            return usersdata;
        }

        public UserData GetUser(string id)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            UserStore<IdentityUser> store = new UserStore<IdentityUser>(context);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            var users = manager.Users.Where(u => u.Id == id).FirstOrDefault();
            UserData userdata = new UserData();
            userdata.Name = users.UserName;
            userdata.Email = users.Email;
            userdata.Phone = users.PhoneNumber;
            userdata.ID = users.Id;
            return userdata;

        }


       
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(string id, UserData userData)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ApplicationDbContext context = new ApplicationDbContext();
            UserStore<IdentityUser> store = new UserStore<IdentityUser>(context);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            var user = manager.FindById(id);
            user.UserName = userData.Name;
            user.Email = userData.Email;
            user.PhoneNumber = userData.Phone;
            manager.Update(user);
            return StatusCode(HttpStatusCode.NoContent);
        }


        public IHttpActionResult DeleteUser(string id)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            UserStore<IdentityUser> store = new UserStore<IdentityUser>(context);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            var user = manager.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            manager.DeleteAsync(user);

            return Ok(user);
        }
    }
}
