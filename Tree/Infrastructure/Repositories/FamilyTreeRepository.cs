using System.Collections.Generic;
using System.Linq;
using Domain.Aggregates;
using Domain.Enums;
using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Repositories
{
    public class FamilyTreeRepository : RepositoryBase<FamilyTree>, IFamilyTreeRepository
    {
        public FamilyTreeRepository()
        {
            _data = new List<FamilyTree>()
            {
                new FamilyTree()
                {
                    UserId = 1,
                    FamilyMembers = new List<Person>()
                    {
                        new Person()
                        {
                            Id = 1,
                            Name = "John",
                            Sex = Sex.Male,
                            Surname = "Kennedy"
                        },
                        new Person()
                        {
                            Id = 2,
                            FatherId = 1,
                            Name = "Joseph",
                            Sex = Sex.Male,
                            Surname = "Kennedy"
                        },
                        new Person()
                        {
                            Id = 3,
                            FatherId = 1,
                            Name = "Rose",
                            Sex = Sex.Female,
                            Surname = "Kennedy"
                        },
                        new Person()
                        {
                            Id = 4,
                            FatherId = 2,
                            Name = "Patrick",
                            Sex = Sex.Male,
                            Surname = "Kennedy"
                        },
                        new Person()
                        {
                            Id = 5,
                            FatherId = 2,
                            Name = "Mary",
                            Sex = Sex.Female,
                            Surname = "Hickey"
                        },
                        new Person()
                        {
                            Id = 6,
                            MotherId = 3,
                            Name = "John",
                            Sex = Sex.Male,
                            Surname = "Fitzgerald"
                        },
                        new Person()
                        {
                            Id = 7,
                            MotherId = 3,
                            Name = "Mary",
                            Sex = Sex.Female,
                            Surname = "Hannon"
                        },
                    }
                }
            };
        }
        public void AddChild(int userId, Person person, int? motherId, int? fatherId)
        {
            var tree = GetById(userId).FamilyMembers;
            if (tree.Find(p => p.Id == person.Id) == null)
            {
                tree.Add(person);
            }
        }

        public void AddParent(int userId, Person person, int childId)
        {
            var tree = GetById(userId).FamilyMembers;
            if (tree.Find(p => p.Id == person.Id) == null)
            {
                tree.Add(person);
            }
        }

        public List<Person> GetChildren(int userId, int personId)
        {
            var tree = GetById(userId).FamilyMembers;
            return tree.Where(p => p?.FatherId == personId || p?.MotherId == personId).ToList();
        }

        public FamilyTree GetById(int userId)
        {
            return _data.Find(f => f.UserId == userId);
        }
    }
}