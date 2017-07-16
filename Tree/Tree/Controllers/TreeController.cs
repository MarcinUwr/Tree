using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Domain.Models.FamilyTree;
using Infrastructure.Repositories;
using Tree.Models;

namespace Tree.Controllers
{
    public class TreeController : Controller
    {
        // GET: Tree
        public ActionResult Index()
        {
            var repo = new FamilyTreeRepository();
            var svc = new FamilyMembersService(repo);
            var tree = svc.GetFamilyTree(1);
            return View(tree);
        }
    }
}