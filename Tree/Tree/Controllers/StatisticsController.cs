using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.AspNet.Identity;
using Tree.Models;

namespace Tree.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Index()
        {
            var context = new TreeDbContext();
            var fTreeRepo = new FamilyTreeRepository(context);
            var personRepo = new PersonRepository(context);
            var svc = new FamilyMembersService(fTreeRepo, personRepo);
            var userId = User.Identity.GetUserId<int>();
            var tree = svc.GetFamilyTree(userId);
            return View(tree);
        }
    }
}