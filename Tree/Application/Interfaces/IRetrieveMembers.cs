using System.Collections.Generic;
using Domain.Models;
using Domain.Models.FamilyTree;

namespace Application.Interfaces
{
    public interface IRetrieveMembers
    {
        NewFamilyTree GetFamilyTree(int userId);
        List<Person> GetChildren(int userId, int personId);
    }
}