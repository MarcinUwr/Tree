using Domain.Models;
using Domain.Models.FamilyTree;
using Domain.Models.Person;

namespace Application.Interfaces
{
    public interface IAddMembers
    {
        void AddFamilyMember(int userId, Person person);
    }
}