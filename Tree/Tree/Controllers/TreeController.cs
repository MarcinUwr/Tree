using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Domain.Models.FamilyTree;
using Domain.Models.Person;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Tree.Builders;
using Tree.Models;
using Tree.ViewModels;

namespace Tree.Controllers
{
    public class TreeController : BaseController
    {
        public ActionResult Index()
        {
            return RedirectToAction("Display");
        }

        public ActionResult Display()
        {   
            var userId = User.Identity.GetUserId<int>();
            var tree = FamilyMembersService.GetFamilyTree(userId)??new FamilyTree();
            
            return View(tree);    
        }

        public ActionResult Add(AddMemberViewModel model)
        {
            var person = new PersonBuilder().Build(model);
            
            var userId = User.Identity.GetUserId<int>();
            FamilyMembersService.AddFamilyMember(userId,person);
            
            return RedirectToAction("Display");
        }

        public ActionResult Remove(int id)
        {
            //todo: remove all dependant members
            
            FamilyMembersService.RemoveFamilyMember(id);

            return RedirectToAction("Display");
        }

        [HttpPost]
        public ActionResult Edit(Person person)
        {
            FamilyMembersService.EditFamilyMember(person);
            return RedirectToAction("Display");
        }
        
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var person = FamilyMembersService.GetFamilyMember(id);
            return View("Edit", person);
        }

        private ApplicationUserManager ApplicationUserManager
            => HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
    }
}