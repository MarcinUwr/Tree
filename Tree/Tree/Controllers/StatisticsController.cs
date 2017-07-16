using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Infrastructure.Repositories;

namespace Tree.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        public ActionResult Index()
        {
            var repo = new FamilyTreeRepository();
            var svc = new FamilyMembersService(repo);
            var tree = svc.GetFamilyTree(1);
            return View(tree);
        }
    }
}