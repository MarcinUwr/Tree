using System.Collections.Generic;
using Domain.Models;
using Domain.Models.FamilyTree;
using Domain.Models.Person;

namespace Application.Interfaces
{
    public interface IRetrieveMembers
    {
        FamilyTree GetFamilyTree(int userId);
        List<Person> GetChildren(int userId, Person person);
    }
}