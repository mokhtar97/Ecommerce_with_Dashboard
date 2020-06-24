using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using WebApplication1.Models;

[assembly: OwinStartup(typeof(WebApplication1.Startup1))]

namespace WebApplication1
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions{
                AccessTokenExpireTimeSpan=TimeSpan.FromDays(1),
                AllowInsecureHttp=true,
                TokenEndpointPath=new PathString("/token"),
                Provider=new OAuthTokenCreate()
            });
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888
            HttpConfiguration config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("Default", "api/{controller}/{id}",
               new { id = RouteParameter.Optional });
            app.UseWebApi(config);

        }
    }

    internal class OAuthTokenCreate : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {

            //owin cors
            context.OwinContext.Response.Headers.Add("Access - Control - Allow - Origin", new[] { "*" });
            ApplicationDbContext dbcontext = new ApplicationDbContext();
            UserStore<IdentityUser> store = new UserStore<IdentityUser>(dbcontext);
            UserManager<IdentityUser> manager = new UserManager<IdentityUser>(store);
            IdentityUser user = manager.Find(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("Grant_type", "INvalid Username OR Password");
                return;
            }
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("Role", "USSER"));
            identity.AddClaim(new Claim("Name", context.UserName));
            context.Validated(identity);

        }
    }
}
