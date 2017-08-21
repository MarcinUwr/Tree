﻿using System;
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
    public class TreeController : Controller
    {
        // GET: Tree
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Display()
        {   
            var context = new TreeDbContext();
            var fTreeRepo = new FamilyTreeRepository(context);
            var personRepo = new PersonRepository(context);
            var svc = new FamilyMembersService(fTreeRepo, personRepo);
            var userId = User.Identity.GetUserId<int>();
            var tree = svc.GetFamilyTree(userId)??new FamilyTree();
            //if (tree != null)
            //{
                return View(tree);
            //}
            //return RedirectToAction("Index");
        }

        public ActionResult Add(AddMemberViewModel model)
        {
            var person = new PersonBuilder().Build(model);
            var context = new TreeDbContext();
            var fTreeRepo = new FamilyTreeRepository(context);
            var personRepo = new PersonRepository(context);
            var svc = new FamilyMembersService(fTreeRepo, personRepo);
            var userId = User.Identity.GetUserId<int>();
            svc.AddFamilyMember(userId,person);
            
            return RedirectToAction("Display");
        }

        public ActionResult Remove(RemoveMemberViewModel model)
        {
            //todo: remove all dependant members
            var context = new TreeDbContext();
            var fTreeRepo = new FamilyTreeRepository(context);
            var personRepo = new PersonRepository(context);
            var svc = new FamilyMembersService(fTreeRepo, personRepo);
            svc.RemoveFamilyMember(model.Id);

            return RedirectToAction("Display");
        }

        private ApplicationUserManager ApplicationUserManager
            => HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
    }
}