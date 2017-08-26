using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application.Services;
using Infrastructure.Repositories;
using Tree.Models;

namespace Tree.Controllers
{
    public class BaseController : Controller
    {
        protected FamilyMembersService FamilyMembersService;
        public BaseController()
        {
            var dbcontext = new TreeDbContext();
            var familyTreeRepository = new FamilyTreeRepository(dbcontext);
            var personRepository = new PersonRepository(dbcontext);
            FamilyMembersService = new FamilyMembersService(familyTreeRepository, personRepository);
        }
    }
}