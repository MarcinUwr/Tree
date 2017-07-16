using System.Collections.Generic;
using System.Linq;
using Domain.Enums;
using Domain.Models;
using Domain.Models.FamilyTree;
using Domain.Models.FamilyTree.Repositories;

namespace Infrastructure.Repositories
{
    public class FamilyTreeRepository : RepositoryBase<NewFamilyTree>, IFamilyTreeRepository
    {
        public FamilyTreeRepository()
        {
            _data = new List<NewFamilyTree>();
            Person p1 = new Person
            {
                Id = 1,
                Name = "John",
                Sex = Sex.Male,
                Surname = "Kennedy"
            };
            Person p2 = new Person
            {
                Id = 2,
                FatherId = 1,
                Name = "Joseph",
                Sex = Sex.Male,
                Surname = "Kennedy"
            };
            Person p3 = new Person
            {
                Id = 3,
                FatherId = 1,
                Name = "Rose",
                Sex = Sex.Female,
                Surname = "Kennedy"
            };
            Person p4 = new Person
            {
                Id = 4,
                FatherId = 2,
                Name = "Patrick",
                Sex = Sex.Male,
                Surname = "Kennedy"
            };
            Person p5 = new Person
            {
                Id = 5,
                FatherId = 2,
                Name = "Mary",
                Sex = Sex.Female,
                Surname = "Hickey"
            };
            Person p6 = new Person
            {
                Id = 6,
                MotherId = 3,
                Name = "John",
                Sex = Sex.Male,
                Surname = "Fitzgerald"
            };
            Person p7 = new Person
            {
                Id = 7,
                MotherId = 3,
                Name = "Mary",
                Sex = Sex.Female,
                Surname = "Hannon"
            };
            Person p8 = new Person
            {
                Id = 8,
                MotherId = 3,
                Name = "Fredro",
                Sex = Sex.Male,
                Surname = "Ayyy"
            };

            NewFamilyTree tree = new NewFamilyTree()
            {
                Root = p1,
                UserId = 1,
                Members = new List<Person>()
            };
            tree.AddMember(p2);
            tree.AddMember(p3);
            tree.AddMember(p4);
            tree.AddMember(p5);
            tree.AddMember(p6);
            tree.AddMember(p7);
            tree.AddMember(p8);

            _data.Add(tree);
        }
        /*
        public void AddChild(int userId, Person person)
        {
            var tree = GetById(userId).Offspring;
            if (tree.Find(p => p.Id == person.Id) == null)
            {
                tree.Add(person);
            }
        }

        public void AddParent(int userId, Person person, int childId)
        {
            var tree = GetById(userId).Offspring;
            if (tree.Find(p => p.Id == person.Id) == null)
            {
                tree.Add(person);
            }
        }

        public List<Person> GetChildren(int userId, int personId)
        {
            var tree = GetById(userId).Offspring;
            return tree.Where(p => p?.FatherId == personId || p?.MotherId == personId).ToList();
        }
        */
        public NewFamilyTree GetById(int userId)
        {
            return _data.Find(f => f.UserId == userId);
        }
        
    }
}