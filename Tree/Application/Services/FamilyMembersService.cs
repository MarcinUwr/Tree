using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;
using Domain.Models;
using Domain.Models.FamilyTree;
using Domain.Models.FamilyTree.Repositories;
using Domain.Models.Person;
using Domain.Models.Person.Repositories;

namespace Application.Services
{
    public class FamilyMembersService : IAddMembers, IRetrieveMembers
    {
        private readonly IFamilyTreeRepository _familyTreeRepository;
        private readonly IPersonRepository _personRepository;

        public FamilyMembersService(IFamilyTreeRepository familyTreeRepository, IPersonRepository personRepository)
        {
            _familyTreeRepository = familyTreeRepository;
            _personRepository = personRepository;
        }

        public void AddFamilyMember(int userId, Person person)
        {
            //var insertedMember = _personRepository.Insert(person);
            _familyTreeRepository.Add(userId, person);
        }

        public void RemoveFamilyMember(int id)
        {
            var person = _personRepository.GetById(id);
            _personRepository.Delete(person);
        }

        public FamilyTree GetFamilyTree(int userId)
        {
            return _familyTreeRepository.GetById(userId);
        }

        public List<Person> GetChildren(int userId, Person person)
        {
            var tree = GetFamilyTree(userId);
            return tree.GetChildren(person);
        }
    }
}