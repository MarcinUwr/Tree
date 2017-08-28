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
    public class StatisticsController : BaseController
    {
        // GET: Statistics
        public ActionResult Index()
        {
            var userId = User.Identity.GetUserId<int>();
            var tree = FamilyMembersService.GetFamilyTree(userId);
            return View(tree);
        }
    }
}