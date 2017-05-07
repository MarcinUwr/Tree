using System.Collections.Generic;
using Domain.Aggregates;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;

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
                    FamilyTree = new FamilyTree()
                    {
                        UserId = 1,
                        FamilyMembers = new List<Person>()
                        {
                            new Person()
                            {
                                Id = 1,
                                FatherId = 2,
                                MotherId = 3,
                                Name = "Marcin",
                                Sex = Sex.Male,
                                Surname = "Owcarz"
                            },
                            new Person()
                            {
                                Id = 3,
                                Name = "Ewa",
                                Sex = Sex.Female,
                                Surname = "Owcarz"
                            },
                            new Person()
                            {
                                Id = 2,
                                Name = "Zbigniew",
                                Sex = Sex.Male,
                                Surname = "Owcarz"
                            }
                        }
                    }
                }
            };
        }
    }
}