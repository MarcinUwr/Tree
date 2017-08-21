using Domain.Models.FamilyTree;
using Domain.Models.Person;
using Domain.Models.User;

namespace Application.Services
{
    public interface IFamilyTreeService
    {
        void AddFamilyMember(Person person);
        void RemoveFamilyMember(Person person);
        FamilyTree GetFamilyTree(TreeUser user);
    }
}