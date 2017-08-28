using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Domain.Models.User;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Tree.Models;
using Tree.ViewModels;

namespace Tree.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var user = User.Identity.GetUserName();
                return View(new TreeUser() {UserName = user});
            }

            else
                return View("RegisterOrLogin");
        }
        
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newUser = new ApplicationUser() {UserName = model.Username};

                var newResult = await
                    ApplicationUserManager.CreateAsync(newUser, model.Password);

                if (newResult.Succeeded)
                {
                    await SignInAsync(newUser, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await ApplicationUserManager.FindAsync(model.UserName, model.Password);
                if (user != null)
                {
                    await SignInAsync(user, model.RememberMe);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            
            return View(model);
        }
        
        //todo: reenable antiforgery
        //[ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            if (ModelState.IsValid)
            {
                AuthenticationManager.SignOut();
            }
            
            return RedirectToAction("Index");
        }



        private async Task SignInAsync(TreeUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie);

            var applicationUser = new ApplicationUser() {UserName = user.UserName, Id = user.Id, };

            var identity = await ApplicationUserManager.CreateIdentityAsync(
               applicationUser, DefaultAuthenticationTypes.ApplicationCookie);

            AuthenticationManager.SignIn(
               new AuthenticationProperties()
               {
                   IsPersistent = isPersistent
               }, identity);
        }

        private IAuthenticationManager AuthenticationManager => HttpContext.GetOwinContext().Authentication;

        private ApplicationUserManager ApplicationUserManager
            => HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
    }
}