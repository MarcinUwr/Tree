using Domain.Models.FamilyTree;
using Domain.Models.FamilyTree.Repositories;
using Domain.Models.Person;
using Domain.Models.Person.Repositories;
using Domain.Models.User;
using Domain.Models.User.Repositories;
using AutoMapper;

namespace Application.Services
{
    public class FamilyTreeService : IFamilyTreeService
    {
        private readonly IFamilyTreeRepository _familyTreeRepo;
        private readonly IPersonRepository _personRepo;
        private readonly IUserRepository _userRepo;

        public FamilyTreeService(IFamilyTreeRepository familyTreeRepo, IPersonRepository personRepo, IUserRepository userRepo)
        {
            _familyTreeRepo = familyTreeRepo;
            _personRepo = personRepo;
            _userRepo = userRepo;
        }

        public void AddFamilyMember(Person person)
        {
            _personRepo.Insert(person);
        }

        public void RemoveFamilyMember(Person person)
        {
            _personRepo.Delete(person);
        }

        public FamilyTree GetFamilyTree(TreeUser user)
        {
            return user.FamilyTree;
        }
    }
}