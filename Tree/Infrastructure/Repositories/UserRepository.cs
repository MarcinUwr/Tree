using System.Collections.Generic;
using Domain.Enums;
using Domain.Models;
using Domain.Models.FamilyTree;
using Domain.Models.User;
using Domain.Models.User.Repositories;

namespace Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository()
        {
            _data = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    Username = "Marcin",
                    FamilyTree = new NewFamilyTree()
                    {
                        UserId = 1
                    }
                }
            };
        }
    }
}