using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;
using Domain.Aggregates;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Services
{
    public class FamilyMembersService : IAddMembers, IRetrieveMembers
    {
        private readonly IFamilyTreeRepository _familyTreeRepository;

        public FamilyMembersService(IFamilyTreeRepository familyTreeRepository)
        {
            _familyTreeRepository = familyTreeRepository;
        }

        public void AddChild(int userId, Person person, int? fatherId, int? motherId)
        {
            _familyTreeRepository.AddChild(userId, person, fatherId, motherId);
        }

        public void AddParent(int userId, Person person, int childId)
        {
            _familyTreeRepository.AddParent(userId, person, childId);
        }

        public FamilyTree GetFamilyTree(int userId)
        {
            return _familyTreeRepository.GetById(userId);
        }

        public List<Person> GetChildren(int userId, int personId)
        {
            return _familyTreeRepository.GetChildren(userId, personId);
        }
    }
}